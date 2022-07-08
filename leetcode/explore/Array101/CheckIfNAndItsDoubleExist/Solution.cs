using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheckIfNAndItsDoubleExist
{
    public class Solution
    {
        public bool CheckIfExist(int[] arr)
        {
            Array.Sort(arr);
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (BinarySearch(arr, arr[i] * 2, i + 1))
                {
                    return true;
                }

                if (BinarySearch(arr, arr[i] / 2.0, i + 1))
                {
                    return true;
                }
            }
            return false;
        }

        public bool BinarySearch(int[] arr, double target, int left)
        {
            int right = arr.Length - 1;
            while (right >= left)
            {
                int mid = (right + left) / 2;
                if (arr[mid] == target)
                {
                    return true;
                }

                if (target > arr[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }
    }
}