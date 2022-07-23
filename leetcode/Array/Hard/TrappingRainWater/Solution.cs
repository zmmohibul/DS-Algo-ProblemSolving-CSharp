using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrappingRainWater
{
    public class Solution
    {
        public int Trap(int[] height)
        {
            int result = 0;
            

            for (int p = 0; p < height.Length; p++)
            {
                int maxLeft = 0;
                int maxRight = 0;
                int currentHeight = height[p];

                for (int i = 0; i <= p; i++)
                {
                    if (height[i] > maxLeft)
                    {
                        maxLeft = height[i];
                    }
                }

                for (int j = p; j < height.Length; j++)
                {
                    if (height[j] > maxRight)
                    {
                        maxRight = height[j];
                    }
                }

                int currentWater = Math.Min(maxLeft, maxRight) - currentHeight;
                if (currentWater >= 0)
                {
                    result += currentWater;
                }
            }

            return result;
        }
    }
}