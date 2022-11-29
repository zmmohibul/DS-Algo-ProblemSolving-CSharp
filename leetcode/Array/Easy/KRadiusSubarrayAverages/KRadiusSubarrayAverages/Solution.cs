using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KRadiusSubarrayAverages
{
    public class Solution
    {
        public static int[] GetAverages(int[] nums, int k)
        {
            int[] result = new int[nums.Length];
            if (k < 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    result[i] = nums[i];
                }
                return result;
            }
            else if (k > nums.Length / 2)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    result[i] = -1;
                }
                return result;
            }

            for (int i = 0; i < k; i++)
            {
                result[i] = -1;
            }

            int radLen = (k * 2 + 1);
            if (radLen > nums.Length)
            {
                for (int i = nums.Length - k; i < nums.Length; i++)
                {
                    result[i] = -1;
                }
                return result;
            }
            long sum = 0;
            for (int i = 0; i < radLen; i++)
            {
                sum += nums[i];
            }
            int average = (int)(sum / radLen);

            int kInd = k;
            result[kInd] = average;
            kInd += 1;

            int left = 0;
            int right = radLen;
            for (int i = k; i < nums.Length - k - 1; i++)
            {
                sum -= nums[left];
                sum += nums[right];
                average = (int)(sum / radLen);
                result[kInd] = average;
                left += 1;
                right += 1;
                kInd += 1;
            }

            for (int i = nums.Length - k; i < nums.Length; i++)
            {
                result[i] = -1;
            }

            return result;
        }
    }
}
