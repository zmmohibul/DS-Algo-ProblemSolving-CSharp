using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringsOfSizeThreeWithDistinctCharacters
{
    public class Solution
    {
        public int CountGoodSubstrings(string s)
        {
            if (s.Length < 3)
            {
                return 0;
            }
            // "xyzzaz"
            //    i j       {x: 0, y: 1, z: 2} result = 1

            // first iterate over s three times and build freq map {a: 2, b: 1}
            // if same char found then change unique flag value
            var freq = new Dictionary<char, int>();
            var unique = true;
            for (int i = 0; i < 3; i++)
            {
                if (freq.ContainsKey(s[i]))
                {
                    unique = false;
                    freq[s[i]] += 1;
                }
                else
                {
                    freq[s[i]] = 1;
                }
            }

            // if unique flag is true then increment result
            int result = 0;
            if (unique)
            {
                result += 1;
            }

            // deduce s[0] from freq map {a: 1, b: 1}
            freq[s[0]] -= 1;

            // start new loop with k = 1, j = 3
            int k = 1;
            for (int j = 3; j < s.Length; j++)
            {
                freq[s[j]] = freq.GetValueOrDefault(s[j], 0) + 1;
                unique = true;
                foreach (var (c, count) in freq)
                {
                    if (count > 1)
                    {
                        unique = false;
                    }
                }

                if (unique)
                {
                    result += 1;
                }

                freq[s[k]] -= 1;
                k += 1;
            }

            // return the result
            return result;
        }
    }
}
