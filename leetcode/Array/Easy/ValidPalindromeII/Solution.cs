using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPalindromeII
{
    public class Solution
    {
        public bool ValidPalindrome(string s) 
        {
            var sb = new StringBuilder(s);
            for (int i = 0; i < s.Length; i++)
            {
                sb.Remove(i, 1);
                if (IsPalindrome(sb))
                {
                    return true;
                }
                sb = new StringBuilder(s);
            }
            return false;
        }

        public bool IsPalindrome(StringBuilder sb)
        {
            int i = 0;
            int j = sb.Length - 1;
            while (j > i)
            {
                if (sb[i] != sb[j])
                {
                    return false;
                }
                i += 1;
                j -= 1;
            }

            return true;
        }
    }
}