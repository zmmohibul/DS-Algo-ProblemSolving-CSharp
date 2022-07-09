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
            // [4,3,2,1]
            //         i
            // digit = = 43
            var digit = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                digit *= 10;
                digit += digits[i];
            }
            
            digit += 1;
            
            var digitCopy = digit;
            var length = 0;
            while (digitCopy > 0)
            {
                length += 1;
                digit /= 10;
            }
            
            var result = new int[length];
            var j = result.Length - 1;
            while (digit > 0)
            {
                result[j] = digit % 10;
                digit /= 10;
                j -= 1;
            }
            
            return result;
        }
    }
}