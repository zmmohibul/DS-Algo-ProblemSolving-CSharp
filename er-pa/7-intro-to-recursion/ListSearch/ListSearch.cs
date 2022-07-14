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
    }
}