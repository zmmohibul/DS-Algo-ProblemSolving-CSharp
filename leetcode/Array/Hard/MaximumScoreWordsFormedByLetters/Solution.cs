using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaximumScoreWordsFormedByLetters
{
    public class Solution
    {
        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            int max = 0;

            var letterIndex = new Dictionary<char, int>();
            var let = 'a';
            for (int i = 0; i < 26; i++)
            {
                letterIndex[let] = i;
                let++;
            }

            var charScore = new Dictionary<char, int>();
            var lettersCount = new Dictionary<char, int>();
            foreach (var letter in letters)
            {
                lettersCount[letter] = lettersCount.GetValueOrDefault(letter, 0) + 1;
                charScore[letter] = score[letterIndex[letter]];
            }

            foreach (var word in words)
            {
                var wordLetterCount = new Dictionary<char, int>();
                foreach (var c in word)
                {
                    wordLetterCount[c] = wordLetterCount.GetValueOrDefault(c, 0) + 1;
                }

                var wordCanBeFormed = true;
                int scr = 0;
                foreach(var (c, count) in wordLetterCount)
                {
                    if (!lettersCount.ContainsKey(c))
                    {
                        wordCanBeFormed = false;
                        break;
                    }
                    else if (lettersCount.ContainsKey(c) && lettersCount[c] < count)
                    {
                        wordCanBeFormed = false;
                        break;
                    }
                    scr = scr + (charScore[c] * count);
                }

                if (wordCanBeFormed)
                {
                    if (scr > max)
                    {
                        max = scr;
                    }
                }

            }

            return max;
        }
    }
}