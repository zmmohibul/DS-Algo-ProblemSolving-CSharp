using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindAnagramMappings
{
    public class Solution
    {
        public int[] AnagramMappings(int[] nums1, int[] nums2) 
        {
            // Brute Force (n^2)
            // Instantiate a result array of length nums1.Length
            int[] result = new int[nums1.Length];

            // Iterate over nums1 with index i 
            for (int i = 0; i < nums1.Length; i++)
            {
                // For each nums1[i] find the position of that nums[i] in nums2 with index j and insert j at result[i]
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums2[j] == nums1[i])
                    {
                        result[i] = j;
                        break;
                    }
                }

            }


            // Return the result array
            return result;
        }
    }
}
