using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CountPrefixesOfGivenString
{
    public class Solution
    {
        public int CountPrefixes(string[] words, string s) 
        {
            var count = 0;
            foreach (var word in words)
            {
                if (s.StartsWith(word))
                {
                    count += 1;
                }
            }
            
            return count;
        }
    }
}