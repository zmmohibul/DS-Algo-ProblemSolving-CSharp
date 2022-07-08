using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidMountainArray
{
    public class Solution
    {
        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3)
            {
                return false;
            }

            int i = 0;
            var we = false;
            while (i < arr.Length - 1 && arr[i + 1] > arr[i])
            {
                i += 1;
                we = true;
            }

            if (i + 1 == arr.Length || !we)
            {
                return false;
            }

            while (i < arr.Length - 1)
            {
                if (!(arr[i + 1] < arr[i]))
                {
                    return false;
                }
                i += 1;
            }

            return true;
        }
    }
}