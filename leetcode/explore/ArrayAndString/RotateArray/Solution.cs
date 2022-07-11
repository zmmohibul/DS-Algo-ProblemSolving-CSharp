using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RotateArray
{
    public class Solution
    {
        public void Rotate(int[] nums, int k) 
        {
            if (nums.Length < 1)
            {
                return;
            }
            
            for (int j = 0; j < k; j++)
            {
                int n = nums[0];
                int n1 = 0;
                for (int i = 1; i < nums.Length; i++)
                {
                    n1 = nums[i];
                    nums[i] = n;
                    n = n1;
                }
                nums[0] = n;
            }
        }
    }
}