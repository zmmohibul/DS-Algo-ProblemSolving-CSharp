using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReplaceElementWithGreatesElementOnRight
{
    public class Solution
    {
        public int[] ReplaceElements(int[] arr)
        {
            int i;
            for (i = 0; i < arr.Length - 1; i++)
            {
                int max = arr[i + 1];
                int j = i + 1;
                while (j < arr.Length)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                    }
                    j += 1;
                }
                arr[i] = max;
            }
            arr[i] = -1;
            return arr;
        }
    }
}