using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMiddleIndexInArray
{
    internal class Solution
    {
        public static int FindMiddleIndex(int[] nums)
        {
            var sumIndex = new Dictionary<int, int>();
            var sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sumIndex[i] = sum;
                sum += nums[i];
            }

            foreach (var (key, val) in sumIndex)
            {
                Console.Write($"{val} - {key}, ");
            }
            Console.WriteLine();

            var jSum = 0;
            for (int j = nums.Length - 1; j > 0; j--)
            {
                if (sumIndex[j] == jSum)
                {
                    return j;
                }
                jSum += nums[j];
            }



            //int iSum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int jSum = 0;
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        jSum += nums[j];
            //    }

            //    if (jSum == iSum)
            //    {
            //        return i;
            //    }

            //    iSum += nums[i];
            //}

            //var sumIndex = new Dictionary<int, int>();
            //var sum = 0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //    sumIndex[sum] = i;
            //}

            //foreach(var (key, val) in sumIndex)
            //{
            //    Console.Write($"{val} - {key}, ");
            //}
            //Console.WriteLine();

            return -1;
        }
    }
}
