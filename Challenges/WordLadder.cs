using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    /*
     * Challenge name: Word Ladder
            Description: 
            Given two words (start and end) and a dictionary, you need to return the shortest length of a sequence of 
            words that takes us from the initial word to the final word. Keep in mind that at each step, only a single letter
            should be changed, and each modified word must be present in the given array, as shown in the following examples:

            Example 1:
            Input: start = “hit”  end = “cog”  dict= [“hot”,”dot”,”dog”,”lot”,”log”]
            Output:  5
            Explanation= "hit-hot-dot-dog-cog = size 5 to reach the word.

            Example 2:
            Input: start = “met”  end = “ced”  dict= ["xet","ten", "cet", "lot","log"]
            Output:  3
            Explanation= "met-cet-ced= size 3 to reach the word.
     */
    public static class WordLadder
    {
        public static List<string> GetShortertLength(string startWord, string endWord, List<string> words)
        {

            if (!words.Any())
                return new List<string>();

            words.Insert(0, startWord);
            words.Add(endWord);
            var oringWords = words;
            
            var firtsWordsLetter = words.Select(word => GetFirstAlphabetLetter(word)).OrderBy(x => x).ToArray();
            var firtsStarWordLetter = GetAlphabetIntegerPosition(GetFirstAlphabetLetter(startWord));
            var firstEndWordLetter = GetAlphabetIntegerPosition(GetFirstAlphabetLetter(endWord));

            var result = new List<string>();

            for (int i = 0; i < firtsWordsLetter.Length; i++)
            {
                var index = GetAlphabetIntegerPosition(firtsWordsLetter[i]);
                var start = firtsStarWordLetter < firstEndWordLetter
                                        ? firtsStarWordLetter
                                        : firstEndWordLetter;
                var end = firstEndWordLetter < firtsStarWordLetter 
                                        ? firtsStarWordLetter 
                                        : firstEndWordLetter;

                if (start <= index  && index <= end)
                    result.Add(words.OrderBy(x => x).ToList()[i]);
            }
            return oringWords.Where(x => result.Contains(x)).ToList();               
        }

        private static int GetAlphabetIntegerPosition(char letter)
        {
            return char.ToUpper(letter) - 64;
        }

        private static char GetFirstAlphabetLetter(string word)
        {
            return word[0];
        }
    }
}
