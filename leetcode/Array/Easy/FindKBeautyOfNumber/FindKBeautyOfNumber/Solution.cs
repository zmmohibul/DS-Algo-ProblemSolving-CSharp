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
            int gNum = num;
            int result = 0;

            int subNum = 0;
            int mod = 1;
            int rem = 0;
            for (int i = 0; i < k; i++)
            {
                int last = rNum % 10;
                last *= mod;
                last += subNum;
                subNum = last;


                mod *= 10;
                rNum /= 10;
            }
            Console.Write(subNum);
            int prevLast = subNum;
            if (subNum > 0 && num % subNum == 0)
            {
                result += 1;
            }

            mod /= 10;
            subNum /= 10;




            while (rNum > 0)
            {
                int last = rNum % 10;
                last *= mod;
                last += (prevLast / 10);
                prevLast = last;

                Console.Write($" {last}");


                if (last > 0 && gNum % last == 0)
                {
                    // Console.Write($" {last}");

                    result += 1;
                }

                // mod *= 10;
                rNum /= 10;
            }

            return result;
        }
    }

}
