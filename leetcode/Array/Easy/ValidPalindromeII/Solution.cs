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
            for (int i = 0; i < s.Length; i++)
            {
                if (IsPalindrome(s, i))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsPalindrome(string sb, int indexToAvoid)
        {
            int i = 0;
            int j = sb.Length - 1;
            bool indexAvoided = false;
            while (j > i)
            {
                if (!indexAvoided)
                {
                    if (i == indexToAvoid)
                    {
                        i += 1;
                        indexAvoided = true;
                    }
                    else if (j == indexToAvoid)
                    {
                        j -= 1;
                        indexAvoided = true;
                    }
                }

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