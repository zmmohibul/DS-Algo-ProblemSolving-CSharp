using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseballGame
{
    public class Solution
    {
        public int CalPoints(string[] ops) 
        {
            var records = new List<int>();
            foreach (var op in ops)
            {
                if (op.Equals("+"))
                {
                    var firstLast = records.Last();
                    var secondLast = records[records.Count - 2];
                    var newScore = firstLast + secondLast;
                    records.Add(newScore);
                }
                else if (op.Equals("D"))
                {
                    var prevScore = records.Last();
                    prevScore *= 2;
                    records.Add(prevScore);
                }
                else if (op.Equals("C"))
                {
                    records.RemoveAt(records.Count - 1);
                }
                else
                {
                    var score = Convert.ToInt32(op);
                    records.Add(score);
                }
            }

            var sum = 0;
            foreach (var record in records)
            {
                sum += record;
            }

            return sum;
        }
    }
}