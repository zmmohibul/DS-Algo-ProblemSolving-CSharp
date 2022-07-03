using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntersectionOfThreeSortedArrays
{
    public class Solution
    {
        public IList<int> ArraysIntersection(int[] arr1, int[] arr2, int[] arr3) 
        {
            // Brute Force O(n log n)
            // arr1 = [1,2,3,4,5], arr2 = [1,2,5,7,9], arr3 = [1,3,4,5,8]
            List<int> result = new List<int>();
            // Iterate over arr1 with index i
            for (int i = 0; i < arr1.Length; i++)
            {
                int ithElementArr1 = arr1[i];
                
            
                // check if arr1[i] exist in arr2 using binary search
                bool ithElementArr1ExistInArr2 = BinarySearch(arr2, ithElementArr1);
            
                // check if arr1[i] exist in arr3 using binary search
                bool ithElementArr1ExistInArr3 = BinarySearch(arr3, ithElementArr1);

                // if arr1[i] exist in arr2 and arr3, add arr1[i] to result
                if (ithElementArr1ExistInArr2 && ithElementArr1ExistInArr3)
                {
                    result.Add(ithElementArr1);
                }
            }
            
            return result;
        }

        public bool BinarySearch(int[] arr, int target)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (j > i)
            {
                int mid = (i + j) / 2;
                if (arr[mid] == target)
                {
                    return true;
                }

                if (arr[mid] > target)
                {
                    j = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    i = mid + 1;
                }
            }

            return false;
        }
    }
}