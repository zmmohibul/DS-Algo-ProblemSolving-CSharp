using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindPivotIndex
{
    public class Solution
    {
        public int PivotIndex(int[] nums) 
        {
            int i = 0;
            int j = nums.Length - 1;
            int iSum = nums[i];
            int jSum = nums[j];
            while (i != j)
            {
                if (iSum < jSum)
                {
                    i += 1;
                    iSum += nums[i];
                }
                else if (jSum < iSum)
                {
                    j -= 1;
                    jSum += nums[j];
                }
                else if (iSum == jSum && i + 1 == j - 1)
                {
                    return j - 1;
                }
                else if (iSum == jSum)
                {
                    i += 1;
                    iSum += nums[i];
                    j -= 1;
                    jSum += nums[j];
                }
                if (j - 1 == i && i == 0)
                {
                    if (jSum == 0)
                    {
                        return 0;
                    }
                }
                
                if (i + 1 == j && j == nums.Length)
                {
                    if (iSum == 0)
                    {
                        return j;
                    }
                }
                
                if (i + 1 == j)
                {
                    break;
                }
            }
            return -1;
        }
    }
}