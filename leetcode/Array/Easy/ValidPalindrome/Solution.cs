using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidPalindrome
{
    public class Solution
    {
        public static bool IsPalindrome(string s) 
        {
            var lowerCaseAlphabets = new HashSet<char>();
            var alphabet = 'a';
            for (int i = 0; i < 26; i++)
            {
                lowerCaseAlphabets.Add(alphabet);
                alphabet++;
            }

            var upperCaseAlphabets = new HashSet<char>();
            alphabet = 'A';
            for (int i = 0; i < 26; i++)
            {
                upperCaseAlphabets.Add(alphabet);
                alphabet++;
            }

            var numbers = new HashSet<char>();
            var number = '0';
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(number);
                number++;
            }

            var sb = new StringBuilder();
            foreach (var c in s)
            {
                if (upperCaseAlphabets.Contains(c))
                {
                    sb.Append((char) (c + 32));
                }
                else if (lowerCaseAlphabets.Contains(c) || numbers.Contains(c))
                {
                    sb.Append(c);
                }
            }

            var j = 0;
            var k = sb.Length;
            while (k > j)
            {
                if (sb[j] != sb[k])
                {
                    return false;
                }
                j += 1;
                k -= 1;
            }

            return true;
        }
    }
}