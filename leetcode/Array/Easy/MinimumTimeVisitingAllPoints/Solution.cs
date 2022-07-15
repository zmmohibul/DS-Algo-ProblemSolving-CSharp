using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinimumTimeVisitingAllPoints
{
    public class Solution
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            var time = 0;
            var point1 = points[0];
            for (int i = 1; i < points.Length; i++)
            {
                var point2 = points[i];
                if (point2[0] > point1[0] && point2[0] > point1[0])
                {
                    var p2min = Math.Min(point2[0], point2[0]);
                    var p1max = Math.Max(point1[0], point1[1]);
                    var diff = p2min - p1max;
                    time += diff;

                    point1[0] += diff;
                    point1[1] += diff;
                }

                if (point2[0] < point1[0] && point2[0] < point1[0])
                {
                    var p2max = Math.Max(point2[0], point2[0]);
                    var p1Min = Math.Max(point1[0], point1[1]);
                    var diff = ;
                    time += diff;

                    point1[0] += diff;
                    point1[1] += diff;
                }
            }

            return time;
        }
    }
}