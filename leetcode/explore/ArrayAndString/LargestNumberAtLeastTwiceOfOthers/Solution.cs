using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LargestNumberAtLeastTwiceOfOthers
{
    public class Solution
    {
        public int DominantIndex(int[] nums) 
        {
            if (nums.Length < 2)
            {
                return 0;
            }
            
            var largest = int.MinValue;
            var largestIndex = -1;
            var secondLargest = int.MinValue;
            var secondLargestIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > largest)
                {
                    secondLargest = largest;
                    secondLargestIndex =largestIndex;
                    largest = nums[i];
                    largestIndex = i;
                }
                else if (nums[i] > secondLargest)
                {
                    secondLargest = nums[i];
                    secondLargestIndex = i;
                }
            }

            System.Console.WriteLine($"{largest} - {largestIndex}");
            System.Console.WriteLine($"{secondLargest} - {secondLargestIndex}");

            if (secondLargest * 2 <= largest)
            {
                return largestIndex;
            }
            
            return -1;
        }
    }
}