using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingsWithAnOceanView
{
    public class Solution
    {
        public int[] FindBuildings(int[] heights) 
        {
            var result = new List<int>();
            var max = 0;
            
            for (int j = heights.Length - 1; j >= 0; j--)
            {
                if (heights[j] > max)
                {
                    max = heights[j];
                    result.Add(j);
                }
            }
            
            var resultArr = new int[result.Count];
            int i = result.Count - 1;
            foreach (var num in result)
            {
                resultArr[i] = num;
                i -= 1;
            }
            
            return resultArr;
        }
    }
}