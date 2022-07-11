using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImplementStrStr
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                var subStr = haystack.Substring(i, needle.Length);
                if (subStr.Equals(needle))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}