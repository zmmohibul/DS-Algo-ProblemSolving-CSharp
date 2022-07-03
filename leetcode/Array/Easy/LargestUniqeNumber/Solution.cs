using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LargestUniqeNumber
{
    public class Solution
    {
        public static int LargestUniqueNumber(int[] nums) 
        {
            // [5,7,3,9,4,9,8,3,1]
            var numFreqInNums = new Dictionary<int, int>(); // numFreqInNums = {}

            // iterate over the array and build the frequency dictionary
            // [5,7,3,9,4,9,8,3,1]
            //                  n
            foreach (var num in nums)
            {
                if (!numFreqInNums.ContainsKey(num))
                {
                    numFreqInNums[num] = 1;
                }
                else
                {
                    numFreqInNums[num] += 1;
                }
            }
            // numFreqInNums = {5: 1, 7: 1, 3: 2, 9: 2, 4: 1, 8: 1, 1: 1}


            // iterate over each item in dictionary and build a list of numbers which appear only once
            // numFreqInNums = {5: 1, 7: 1, 3: 2, 9: 2, 4: 1, 8: 1, 1: 1}
            //                                                      n  c
            var numsThatAppearOnlyOnce = new List<int>(); // numsThatAppearOnlyOnce = []
            foreach (var (num, count) in numFreqInNums)
            {
                if (count == 1)
                {
                    numsThatAppearOnlyOnce.Add(num);
                }
            }
            // numsThatAppearOnlyOnce = [5, 7, 4, 8, 1]


            // if list is empty now then return -1
            if (numsThatAppearOnlyOnce.Count == 0)
            {
                return -1;
            }

            // iterate over the list and find the largest number there 
            // numsThatAppearOnlyOnce = [5, 7, 4, 8, 1]
            //                                       n
            int answer = int.MinValue;
            foreach (var num in numsThatAppearOnlyOnce)
            {
                if (num > answer)
                {
                    answer = num;
                }
            }
            // answer = 8

            return answer;
        }
    }
}