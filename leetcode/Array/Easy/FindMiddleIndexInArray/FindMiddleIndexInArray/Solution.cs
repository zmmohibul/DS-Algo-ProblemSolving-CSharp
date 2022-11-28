using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMiddleIndexInArray
{
    internal class Solution
    {
        public static int FindMiddleIndex(int[] nums)
        {
            int iSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int jSum = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    jSum += nums[j];
                }

                if (jSum == iSum)
                {
                    return i;
                }

                iSum += nums[i];
            }

            return -1;
        }
    }
}
