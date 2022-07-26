using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortestDistanceToTargetColor
{
    public class Solution
    {
        public IList<int> ShortestDistanceColor(int[] colors, int[][] queries) 
        {
            var result = new List<int>();
            foreach (var query in queries)
            {
                var index = query[0];
                var color = query[1];
                
                var i = index;
                var j = index;
                
                var jDist = 0;
                var jNoCol = true;
                while (j < colors.Length)
                {
                    if (colors[j] == color)
                    {
                        jNoCol = false;
                        break;
                    }
                    else
                    {
                        j += 1;
                        jDist += 1;
                    }
                }
                
                var iDist = 0;
                var iNoCol = true;
                while (i >= 0)
                {
                    if (colors[i] == color)
                    {
                        iNoCol = false;
                        break;
                    }
                    else
                    {
                        iDist += 1;
                        i -= 1;
                    }
                }
                
                if (jNoCol && iNoCol)
                {
                    result.Add(-1);
                    continue;
                }
                else if (jNoCol)
                {
                    result.Add(iDist);
                    continue;
                }
                else if (iNoCol)
                {
                    result.Add(jDist);
                    continue;
                }
                            
                if (jDist <= iDist)
                {
                    result.Add(jDist);
                }
                else
                {
                    result.Add(iDist);
                }
            }
            
            return result;
        }
    }
}