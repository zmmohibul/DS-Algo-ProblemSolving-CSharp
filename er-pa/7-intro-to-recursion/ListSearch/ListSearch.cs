using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListSearch
{
    public class ListSearch
    {
        public int LinearSearch(List<int> nums, int value)
        {
            return LinearSearch(nums, value, 0);
        }

        private int LinearSearch(List<int> nums, int value, int index)
        {
            if (index == nums.Count)
            {
                return -1;
            }
            else if (nums[index] == value)
            {
                return index;
            }
            else
            {
                return LinearSearch(nums, value, index + 1);
            }
        }

        public int BinarySearch(List<int> nums, int value)
        {
            return BinarySearch(nums, value, 0, nums.Count - 1);
        }

        private int BinarySearch(List<int> nums, int value, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int mid = (left + right) / 2;
            if (nums[mid] == value)
            {
                return mid;
            }
            else if (value < nums[mid])
            {
                return BinarySearch(nums, value, left, mid - 1);
            }
            else
            {
                return BinarySearch(nums, value, mid + 1, right);
            }
        }
    }
}