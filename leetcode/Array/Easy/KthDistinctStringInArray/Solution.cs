using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KthDistinctStringInArray
{
    public class Solution
    {
        public string KthDistinct(string[] arr, int k) 
        {
            // iterate over arr and build a dictionary tracking frequency of each string
            var arrStringFreq = new Dictionary<string, int>();
            foreach (var str in arr)
            {
                arrStringFreq[str] = arrStringFreq.GetValueOrDefault(str, 0) + 1;
            }
            
            // iterate over arr again and check if item appears only once in arr
            // also keep a count variable to keep track whether the item is 1st, 2nd, 3rd
            var count = 0;
            foreach (var str in arr)
            {
                if (arrStringFreq[str] == 1)
                {
                    count += 1;
                }
                
                if (count == k)
                {
                    return str;
                }
            }
            
            return string.Empty;
        }
    }
}