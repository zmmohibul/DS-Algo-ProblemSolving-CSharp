using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatedDNASequence
{
    internal class Solution
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            var result = new List<string>();

            if (s.Length < 11)
            {
                return result;
            }
            var sequenceCount = new Dictionary<string, int>();
            var sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(s[i]);
            }
            sequenceCount[sb.ToString()] = 1;

            for (int right = 10; right < s.Length; right++)
            {
                sb.Remove(0, 1);
                sb.Append(s[right]);
                sequenceCount[sb.ToString()] = sequenceCount.GetValueOrDefault(sb.ToString(), 0) + 1;
                if (sequenceCount[sb.ToString()] == 1)
                {
                    result.Add(sb.ToString());
                }
            }

            return result;
        }
    }
}
