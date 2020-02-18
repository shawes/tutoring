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
            string[] firstWord = new string[3] { "a", "the", "of" };

            var word = words[0];
            words[0] = Char.ToUpper(word[0]) + words[0].Substring(1);

            for (int i = 1; i < words.Length; i++){
                if(!firstWord.Contains(words[i])) {
                    var tempWord = words[i];
                    words[i] = Char.ToUpper(tempWord[0]) + words[i].Substring(1);
                }
            }
            Console.WriteLine(String.Join(' ',words));
            
        }
    
    }
}