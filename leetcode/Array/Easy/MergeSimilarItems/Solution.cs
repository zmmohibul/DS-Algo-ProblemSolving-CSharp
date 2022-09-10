using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MergeSimilarItems
{
    public class Solution
    {
        public IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2) {
            var result = new List<IList<int>>();
            var d1 = new Dictionary<int, int>();
            
            foreach (var item in items1)
            {
                d1[item[0]] = d1.GetValueOrDefault(item[0], 0) + item[1];
            }
            
            foreach (var item in items2)
            {
                d1[item[0]] = d1.GetValueOrDefault(item[0], 0) + item[1];
            }
            
            var valList = new List<int>();
            foreach (var (val, weight) in d1)
            {
                valList.Add(val);
            }
            
            valList.Sort();
            foreach (var val in valList)
            {
                result.Add(new List<int>(){val, d1[val]});
            }
            
            return result;
            
        }
    }
}