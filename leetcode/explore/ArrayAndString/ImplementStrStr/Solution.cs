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
            
            var sb = new StringBuilder(haystack.Substring(0, needle.Length));
            
            int j = 0;
            for (int i = needle.Length; i < haystack.Length; i++)
            {
                System.Console.WriteLine(sb);
                if (sb.Equals(needle))
                {
                    return j;
                }
                sb.Remove(0, 1);
                sb.Append(haystack[i]);
                j += 1;
            }

            return -1;
        }
    }
}