using System;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase: ");

            string phrase = Console.ReadLine().ToLower();
            string reversephrase = Reverse(phrase);

            if (phrase.CompareTo(reversephrase) == 0)
            {
                Console.WriteLine("You have found a palindrome. Claps");
            }
            else
            {
                Console.WriteLine("Get out of here, this isn't a palindrome");
            }
            // }
        }

        public static string Reverse(string s)
        {
            var stringAsChars = s.ToCharArray();
            Array.Reverse(stringAsChars);
            return new string(stringAsChars);
        }
    }
}
