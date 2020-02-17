using System;

namespace Primes
{
    class Program
    {
        static void Main(string[] args)
        {    
          Console.Write("Enter an integer: ");    
          int n = Convert.ToInt32(Console.ReadLine());  
 
          if (isThisNumberPrime(n)) {
           Console.WriteLine("You found a prime!"); 
          } else {
            Console.WriteLine("No dice on the prime.."); 
          }
        }  

        static bool isThisNumberPrime(int n) {
            if(n <= 1) return false;

            for(int i = 2; i <= n/2; i++)    
            {    
            if(n % i == 0)      
                return false; 
            }

            return true; 
        }
    }
}


