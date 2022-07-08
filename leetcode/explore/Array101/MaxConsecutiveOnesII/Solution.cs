using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaxConsecutiveOnesII
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums) 
        {
            int maxCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int j = i;
                int count = 0;
                int zCount = 0;
                while (j < nums.Length)
                {
                    if (nums[j] == 0)
                    {
                        zCount += 1;
                    }
                    
                    if (zCount == 2)
                    {
                        break;
                    }
                    j += 1;
                    count += 1;
                }
                
                if (count > maxCount)
                {
                    maxCount = count;
                }
                
                i = j - 1;
            }
            
            return maxCount;
            
        }
    }
}