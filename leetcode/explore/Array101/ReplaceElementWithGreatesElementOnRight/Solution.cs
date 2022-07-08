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
            int i = arr.Length - 1;
            int max = arr[i];
            while (i > 0)
            {
                i -= 1;
                int newMax = 0;
                if (arr[i] > max)
                {
                    newMax = arr[i];
                    arr[i] = max;
                    max = newMax;
                }
                else
                {
                    arr[i] = max;
                }
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }
    }
}