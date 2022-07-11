using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            
            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            var sb = new StringBuilder(haystack.Substring(0, needle.Length));
            if (sb.Equals(needle))
            {
                return 0;
            }

            int j = 0;
            for (int i = needle.Length; i < haystack.Length; i++)
            {
                sb.Remove(0, 1);
                sb.Append(haystack[i]);
                j += 1;
                if (sb.Equals(needle))
                {
                    return j;
                }
            }

            return -1;
        }
    }
}