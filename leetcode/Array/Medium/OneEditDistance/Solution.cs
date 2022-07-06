using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneEditDistance
{
    public class Solution
    {
        public bool IsOneEditDistance(string s, string t) 
        {
            var sChFreq = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                sChFreq[ch] = sChFreq.GetValueOrDefault(ch, 0) + 1;
            }

            var tChFreq = new Dictionary<char, int>();
            foreach (var ch in t)
            {
                tChFreq[ch] = tChFreq.GetValueOrDefault(ch, 0) + 1;
            }

            var dictToStartWith = new Dictionary<char, int>();
            var otherDict = new Dictionary<char, int>();
            if (sChFreq.Count >= tChFreq.Count)
            {
                dictToStartWith = sChFreq;
                otherDict = tChFreq;
            }
            else
            {
                dictToStartWith = tChFreq;
                otherDict = sChFreq;
            }

            var problems = 0;
            foreach (var (ch, count) in dictToStartWith)
            {
                if (!otherDict.ContainsKey(ch))
                {
                    problems += 1;
                }

                if (otherDict.ContainsKey(ch) && otherDict[ch] != count)
                {

                    problems += (Math.Max(count, otherDict[ch]) - Math.Min(count, otherDict[ch]));
                }

                if (problems > 1)
                {
                    return false;
                }
            }

            if (problems > 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}