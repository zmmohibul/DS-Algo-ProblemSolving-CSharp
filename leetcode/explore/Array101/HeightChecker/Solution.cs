using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HeightChecker
{
    public class Solution
    {
        public int HeightChecker(int[] heights) 
        {
            // [1,1,4,2,1,3]
            
            // [1,1,1,2,3,4]
            //            i
            // count = 1 + 1 + 1 = 3
            var expected = new int[heights.Length];
            for (int i = 0; i < heights.Length; i++)
            {
                expected[i] = heights[i];
            }
            
            Array.Sort(expected);
            
            var count = 0;
            for (int i = 0; i < expected.Length; i++)
            {
                if (expected[i] != heights[i])
                {
                    count += 1;
                }
            }
            
            return count;
        }
    }
}