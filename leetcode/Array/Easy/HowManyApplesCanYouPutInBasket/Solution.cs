using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyApplesCanYouPutInBasket
{
    public class Solution
    {
        public int MaxNumberOfApples(int[] weight) 
        {
            Array.Sort(weight);
            
            var limit = 5000;
            var count = 0;
            var currWeight = 0;
            
            for (int i = 0; i < weight.Length; i++)
            {
                if (currWeight + weight[i] > limit)
                {
                    break;
                }
                
                count += 1;
                currWeight += weight[i];
            }
            
            return count;
        }
        
        
    }
}