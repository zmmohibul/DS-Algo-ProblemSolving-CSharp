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
            // Brute Force O(n^2)
            // arr1 = [1,2,3,4,5], arr2 = [1,2,5,7,9], arr3 = [1,3,4,5,8]
            List<int> result = new List<int>();
            // Iterate over arr1 with index i
            for (int i = 0; i < arr1.Length; i++)
            {
                int ithElementArr1 = arr1[i];
            
                // check if arr1[i] exist in arr2
                bool ithElementArr1ExistInArr2 = false;
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr2[j] == ithElementArr1)
                    {
                        ithElementArr1ExistInArr2 = true;
                        break;
                    }
                }
            
                // check if arr1[i] exist in arr3
                bool ithElementArr1ExistInArr3 = false;
                for (int k = 0; k < arr3.Length; k++)
                {
                    if (arr3[k] == ithElementArr1)
                    {
                        ithElementArr1ExistInArr3 = true;
                        break;
                    }
                }

                // if arr1[i] exist in arr2 and arr3, add arr1[i] to result
                if (ithElementArr1ExistInArr2 && ithElementArr1ExistInArr3)
                {
                    result.Add(ithElementArr1);
                }
            }
            
            return result;
        }
    }
}