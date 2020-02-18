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
            //reversephrase += phrase;
            //for (int i = phrase.Length - 1; i >= 0; i--) {

            if (phrase == reversephrase)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
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
