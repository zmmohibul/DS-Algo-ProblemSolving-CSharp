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
            for (int i = 0; i < words.Length; i++)
            {
                var word = new StringBuilder(words[i]);
                for (int j = 0; j < words.Length; j++)
                {
                    if (j != i)
                    {
                        word.Append(words[j]);
                    }
                }
                System.Console.WriteLine(word);

                var subS = new StringBuilder();
                for (int j = 0; j < word.Length; j++)
                {
                    subS.Append(s[j]);
                }
                // System.Console.WriteLine(subS);

                if (subS.Equals(word))
                {
                    result.Add(0);
                }

                int k = 0;
                int l = word.Length;
                while (l < s.Length)
                {
                    subS.Remove(0, 1);
                    subS.Append(s[l]);
                    // System.Console.WriteLine(subS);

                    k += 1;
                    l += 1;

                    if (subS.Equals(word))
                    {
                        result.Add(k);
                    }
                }
            }
            
            return result;
        }
    }
}