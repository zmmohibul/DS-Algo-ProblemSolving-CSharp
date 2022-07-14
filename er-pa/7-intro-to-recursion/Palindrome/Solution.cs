using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Solution
    {
        public bool IsPalindrome(string str)
        {
            return IsPalindrome(str, 0, str.Length - 1);
        }

        private bool IsPalindrome(string str, int p1, int p2)
        {
            if (p1 >= p2)
            {
                return true;
            }

            if (str[p1] != str[p2])
            {
                return false;
            }

            return IsPalindrome(str, p1 + 1, p2 - 1);
        }
    }
}