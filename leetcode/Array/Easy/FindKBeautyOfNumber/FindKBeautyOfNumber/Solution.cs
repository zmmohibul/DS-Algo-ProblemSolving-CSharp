using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindKBeautyOfNumber
{
    public class Solution
    {
        public int DivisorSubstrings(int num, int k)
        {
            int rNum = num;
            int result = 0;
            var numList = new List<int>();
            while (num > 0)
            {
                numList.Add(num % 10);
                num /= 10;
            }

            int x = numList.Count - 1;
            int subNum = 0;
            int mod = 1;
            for (int i = 0; i < k; i++)
            {
                subNum *= 10;
                subNum += numList[x];
                x -= 1;
                mod *= 10;
            }
            mod /= 10;
            if (subNum > 0 && rNum % subNum == 0)
            {
                result += 1;
            }

            // Console.WriteLine(mod);
            // Console.Write(subNum);
            for (int i = numList.Count - 1 - k; i >= 0; i--)
            {
                subNum = subNum % mod;
                subNum *= 10;
                subNum += numList[i];

                if (subNum > 0 && rNum % subNum == 0)
                {
                    // Console.Write($" {subNum}");

                    result += 1;
                }
            }

            return result;
        }
    }

}
