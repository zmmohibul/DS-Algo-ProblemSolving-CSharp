using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortestDistanceToCharacter
{
    public class Solution
    {
        public int[] ShortestToChar(string s, char c) 
        {
            int[] result = new int[s.Length];
            var cOccurences = new Queue<int>();
            for (int i = 0; i < s.Length; i++) 
            {
                if (s[i] == c)
                {
                    cOccurences.Enqueue(i);
                }
            }

            var firstCInd = cOccurences.Dequeue();
            int j = 0;
            while (j <= firstCInd)
            {
                result[j] = Math.Abs(j - firstCInd);
                j += 1;
            }

            var secondCInd = int.MaxValue;
            if (cOccurences.Any())
            {
                secondCInd = cOccurences.Dequeue();
            }

            for (int i = j; i < s.Length; i++)
            {
                if (i == secondCInd)
                {
                    firstCInd = secondCInd;
                    secondCInd = int.MaxValue;
                    if (cOccurences.Any())
                    {
                        secondCInd = cOccurences.Dequeue();
                    }
                }

                var leftDist = Math.Abs(i - firstCInd);
                var rightDist = Math.Abs(i - secondCInd);

                if (leftDist < rightDist) 
                {
                    result[i] = leftDist;
                }
                else
                {
                    result[i] = rightDist;
                }

                
            }

            return result;
        }
    }
}