using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmbeddedWords
{
    public class Solution
    {
        public void EmbeddedWords(string str)
        {
            foreach (var s in EmbeddedWords(new StringBuilder(str)))
            {
                System.Console.WriteLine(s);
            }
        }

        public HashSet<string> EmbeddedWords(StringBuilder sb)
        {
            var result = new HashSet<string>();
            if (sb.Length == 1)
            {
                result.Add(sb.ToString());
            }
            else 
            {
                var c = sb[0];
                sb.Remove(0, 1);
                var r = EmbeddedWords(sb);
                foreach (var s in r)
                {
                    result.Add(s);
                    result.Add(c + s);
                }
            }
            
            return result;
        }
    }
}