using System;
using System.Linq;

namespace Capitalisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a phrase: ");
            string phrase = Console.ReadLine();

            string[] words = phrase.Split(' ');
            string[] doNotCapitaliseList = new string[3] { "a", "the", "of" };

            words[0] = ToSentenceCase(words[0]); // Capitalise the first word regardless

            for (int i = 1; i < words.Length; i++)
            {
                if (!doNotCapitaliseList.Contains(words[i]))
                {
                    words[i] = ToSentenceCase(words[i]);
                }
            }

            Console.WriteLine(String.Join(' ', words));
        }

        private static String ToSentenceCase(String s)
        {
            return Char.ToUpper(s[0]) + s.Substring(1);
        }

    }
}