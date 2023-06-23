using ConsolePuzzles.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePuzzles.Puzzles
{
    internal class WordCounter : IConsolePuzzle
    {
        public void Start()
        {
            Console.WriteLine("Enter a paragraph of text.");
            var input = Console.ReadLine();

            var wordCount = CountWordFrequencies(input);

            foreach (var word in wordCount)
            {
                Console.WriteLine($"{word.Key}: {word.Value}");
            }
        }

        private Dictionary<string, int> CountWordFrequencies(string input)
        {
            var wordCount = new Dictionary<string, int>();

            // split input into words

            var words = input.Split(' ');

            // loop through words
            foreach (var word in words)
            {
                // remove punctuation
                var cleanedWord = new string(word.Where(char.IsLetter).ToArray()).ToLower();

                // if word is in dictionary, increment count
                if (wordCount.ContainsKey(cleanedWord))
                {
                    wordCount[cleanedWord]++;
                }
                else
                {
                    wordCount.Add(cleanedWord, 1);
                }
            }
            
            wordCount.OrderBy(x => x);
            return wordCount;
        }
    }
}
