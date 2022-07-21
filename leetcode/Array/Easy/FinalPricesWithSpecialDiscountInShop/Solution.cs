using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalPricesWithSpecialDiscountInShop
{
    public class Solution
    {
        public int[] FinalPrices(int[] prices) 
        {
            int[] result = new int[prices.Length];
            
            for (int i = 0; i < prices.Length; i++)
            {
                int num = prices[i];
                
                int discount = -1;
                int j = i + 1;
                while (j < prices.Length)
                {
                    if (prices[j] <= num)
                    {
                        discount = prices[j];
                        break;
                    }
                    
                    j += 1;
                }
                
                if (discount > -1)
                {
                    int newPrice = num - discount;
                    result[i] = newPrice;
                }
                else
                {
                    result[i] = num;
                }
            }
            
            return result;
        }
    }
}