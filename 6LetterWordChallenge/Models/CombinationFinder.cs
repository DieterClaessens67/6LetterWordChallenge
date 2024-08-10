using _6LetterWordChallenge.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LetterWordChallenge.Models
{
    public class CombinationFinder : ICombinationFinder
    {
        public IEnumerable<string> FindLetterCombinations(string[] words, int lengthOfWord)
        {
            IEnumerable<string> distinctWords = words.Distinct();
            List<string> wordsToTryAndMake = new List<string>();
            foreach(string word in distinctWords)
            {
                if(word.Length == lengthOfWord)
                {
                    wordsToTryAndMake.Add(word);
                }
            }
            HashSet<string> combinations = new HashSet<string>();
            FindAllLetterCombinations(distinctWords.ToList(), "", 0, combinations, wordsToTryAndMake, lengthOfWord);

            return combinations;
        }

        private void FindAllLetterCombinations(List<string> distinctWords, string currentWord, int index, HashSet<string> combinations, IEnumerable<string> wordsToTryAndMake, int lengthOfWord)
        {
            if (currentWord.Length >= 6) 
            {
                if (currentWord.Length == 6 && !combinations.Contains(currentWord) && wordsToTryAndMake.Contains(currentWord))
                {
                    combinations.Add(currentWord);
                }
                return;
            }

            for (int i = index; i < distinctWords.Count(); i++)
            {
                FindAllLetterCombinations(distinctWords, currentWord + distinctWords[i], i + 1, combinations, wordsToTryAndMake, lengthOfWord);
            }
        }
    }
}
