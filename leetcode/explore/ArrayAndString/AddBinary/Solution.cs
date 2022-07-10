using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b) 
        {
            // 1101 
            //  101

            int i = a.Length - 1;
            int j = b.Length - 1;
            int carry = 0;
            var result = string.Empty;
            while (i >= 0 && j >= 0)
            {
                var n1 = char.GetNumericValue(a[i]);
                var n2 = char.GetNumericValue(b[j]);
                var sum = n1 + n2 + carry;
                System.Console.WriteLine($"{n1} + {n2} + {carry} = {sum}");
                if (sum == 3)
                {
                    // 11
                    result = 1 + result;
                    carry = 1;
                }
                else if (sum == 2)
                {
                    // 10
                    result = 0 + result;
                    carry = 1;
                }
                else if (sum < 2)
                {
                    // 1 || 0
                    result = sum + result;
                    carry = 0;
                }
                i -= 1;
                j -= 1;
            }

            int x = -1;
            string remString = string.Empty;
            if (i >= 0)
            {
                x = i;
                remString = a;
            }

            if (j >= 0)
            {
                x = j;
                remString = b;
            }

            while (x >= 0)
            {
                var n1 = char.GetNumericValue(remString[x]);
                var sum = n1 + carry;

                if (sum == 2)
                {
                    // 10
                    result = 0 + result;
                    carry = 1;
                }
                else if (sum < 2)
                {
                    // 1 || 0
                    result = sum + result;
                    carry = 0;
                }

                x -= 1;
            }

            if (carry == 1)
            {
                result = 1 + result;
            }

            return result;
        }
    }
}