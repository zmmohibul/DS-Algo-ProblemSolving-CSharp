using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAnagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs) 
        {
            var indexGrouped = new HashSet<int>();
            int i = 0;
            while (i < strs.Length)
            {
                if (!indexGrouped.Contains(i))
                {
                    var str = strs[i];
                    var strCharFreq = new Dictionary<int, int>();
                    foreach (var ch in str)
                    {
                        strCharFreq[ch] = strCharFreq.GetValueOrDefault(ch, 0) + 1;
                    }
                    
                    var group = new List<string>();
                    group.Add(str);
                    indexGrouped.Add(i);

                    int j = 0;
                    while (j < strs.Length)
                    {
                        if (j != i && !indexGrouped.Contains(j))
                        {
                            var strj = strs[j];
                            var strjCharFreq = new Dictionary<int, int>();
                            foreach (var ch in strj)
                            {
                                strjCharFreq[ch] = strjCharFreq.GetValueOrDefault(ch, 0) + 1;
                            }

                            if (strCharFreq.Count != strjCharFreq.Count)
                            {
                                continue;
                            }
                        }
                    }
                }
            }
        }
    }
}