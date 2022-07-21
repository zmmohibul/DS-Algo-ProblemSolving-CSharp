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
        
        public int MaxNumberOfApples(int[] weight, int currWeight, int index, int count) 
        {
            if (currWeight > 5000 || index == weight.Length)
            {
                return count;
            }
            else
            {
                return Math.Max(MaxNumberOfApples(weight, currWeight + weight[index], index + 1, count + 1), MaxNumberOfApples(weight, currWeight, index + 1, count));
            }
        }
    }
}