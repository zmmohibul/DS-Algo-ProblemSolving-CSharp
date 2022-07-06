using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidAnagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            var scFreq = new Dictionary<char, int>();
            foreach (var ch in s)
            {
                scFreq[ch] = scFreq.GetValueOrDefault(ch, 0) + 1;
            }
            
            var tcFreq = new Dictionary<char, int>();
            foreach (var ch in t)
            {
                if (!scFreq.ContainsKey(ch))
                {
                    return false;
                }
                
                tcFreq[ch] = tcFreq.GetValueOrDefault(ch, 0) + 1;
            }
            
            foreach (var (ch, count) in scFreq)
            {
                if (!tcFreq.ContainsKey(ch) || tcFreq[ch] != count)
                {
                    return false;
                }
            }
            
            foreach (var (ch, count) in tcFreq)
            {
                if (!scFreq.ContainsKey(ch) || scFreq[ch] != count)
                {
                    return false;
                }
            }
            
            return true;
        }
    }
}