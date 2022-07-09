using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits) 
        {
            var allNine = true;
            for (int i = 0; i < digits.Length; i++)
            {
                if (digits[i] != 9)
                {
                    allNine = false;
                    break;
                }
            }
            
            if (allNine)
            {
                var r = new int[digits.Length + 1];
                r[0] = 1;
                return r;
            }
            
            var result = new int[digits.Length];
            var last = 1;
            for (int j = digits.Length - 1; j >= 0; j--)
            {
                last += digits[j];
                result[j] = last % 10;
                last /= 10;
            }
            
            return result;
        }
    }
}