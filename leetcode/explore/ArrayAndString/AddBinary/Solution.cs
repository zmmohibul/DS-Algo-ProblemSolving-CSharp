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
            int minLength = 0;
            int maxLength = 0;
            string maxString = string.Empty;
            if (a.Length <= b.Length)
            {
                minLength = a.Length;
                maxLength = b.Length;
                maxString = b;
            }
            else
            {
                minLength = b.Length;
                maxLength = a.Length;
                maxString = a;
            }
            
            var sb = new StringBuilder();
            int carry = 0;
            for (int i = minLength - 1; i >= 0; i--)
            {
                int n1 = (int) a[i];
                int n2 = (int) b[i];

                int sum = n1 + n2 + carry;
                if (sum == 3)
                {
                    carry = 1;
                    sb.Append(1);
                }
                else if (sum == 2)
                {
                    carry = 1;
                    sb.Append(0);
                }
                else if (sum < 2)
                {
                    carry = 0;
                    sb.Append(sum);
                }
            }

            if (minLength == maxLength)
            {
                if (carry != 0)
                {
                    sb.Append(carry);
                }
                return sb.ToString().Reverse().ToString();
            }

            int j = maxLength - minLength - 1;
            while (j >= 0)
            {
                int sum = carry + maxString[j];
                if (sum == 2)
                {
                    carry = 1;
                    sb.Append(0);
                }
                else if (sum < 2)
                {
                    carry = 0;
                    sb.Append(sum);
                }
                j -= 1;
            }

            return sb.ToString().Reverse().ToString();
        }
    }
}