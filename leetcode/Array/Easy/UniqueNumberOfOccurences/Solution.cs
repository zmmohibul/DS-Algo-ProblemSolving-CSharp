using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniqueNumberOfOccurences
{
    public class Solution
    {
        public bool UniqueOccurrences(int[] arr) 
        {
            // Iterate over each items in arr and build a dictionary of freq of each num
            var numFreq = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                numFreq[num] = numFreq.GetValueOrDefault(num, 0) + 1;
            }
            
            // Iterate over each item in dictionary and add count to a hash set while checking if the count is already in the hash set. If it is then return false.
            var hs = new HashSet<int>();
            foreach (var (num, count) in numFreq)
            {
                if (hs.Contains(count))
                {
                    return false;
                }
                
                hs.Add(count);
            }
            
            return true;
        }
    }
}