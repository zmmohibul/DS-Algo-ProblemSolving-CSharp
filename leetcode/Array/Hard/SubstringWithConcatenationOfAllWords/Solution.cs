using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubstringWithConcatenationOfAllWords
{
    public class Solution
    {
        public IList<int> FindSubstring(string s, string[] words) 
        {
            var result = new List<int>();
            var sminlen = words.Length * words[0].Length;
            for (int i = 0; i <= s.Length - sminlen; i++)
            {
                var d = new Dictionary<string, int>();
                foreach (var word in words)
                {
                    d[word] = d.GetValueOrDefault(word, 0) + 1;
                }

                int k = i;
                var found = true;
                for (int j = 0; j < words.Length; j++)
                {
                    // var w = new StringBuilder();
                    // for (int l = 0; l < words[0].Length; l++)
                    // {
                    //     w.Append(s[k]);
                    //     k += 1;
                        
                    // }

                    var ww = s.Substring(k, words[0].Length);
                    System.Console.WriteLine(ww);
                    k += words[0].Length;

                    if (d.ContainsKey(ww) && d[ww] > 0)
                    {
                        d[ww] -= 1;
                    }
                    else 
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    result.Add(i);
                }
            }
            
            return result;
        }
    }
}