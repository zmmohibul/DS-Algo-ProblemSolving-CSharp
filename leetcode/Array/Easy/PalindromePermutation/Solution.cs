using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PalindromePermutation
{
    public class Solution
    {
        public bool CanPermutePalindrome(string s) 
        {
            Dictionary<char, int> charFreq = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!charFreq.ContainsKey(s[i]))
                {
                    charFreq[s[i]] = 1;
                }
                else
                {
                    charFreq[s[i]] += 1;
                }
            }

            var unevenChars = 0;
            foreach (var (ch, count) in charFreq)
            {
                if (count % 2 != 0)
                {
                    unevenChars += 1;
                }
                if (unevenChars > 1)
                {
                    return false;
                }
            }
            return true;
        }
    }
}