using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DuplicateZeros
{
    public class Solution
    {
        public void DuplicateZeros(int[] arr) 
        {
            // [1,0,2,3,0,4,5,0]
            //    i            
            
            // Iterate over each item in arr with index i
            for (int i = 0; i < arr.Length - 1; i++)
            {
                // If arr[i] == 0 then every item to right from arr.Length - 2 till (i + 1)
                if (arr[i] == 0)
                {
                    int j = arr.Length - 2;
                    while (j >= i + 1)
                    {
                        arr[j + 1] = arr[j];
                        j -= 1;
                    }
                    
                    // Insert at arr[i + 1] 0.
                    arr[i + 1] = 0;
        
                    // Increment i    
                    i += 1;
                }
                
            }
        }
    }
}