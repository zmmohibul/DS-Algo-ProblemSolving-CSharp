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
            var sum = 0;
            foreach (var op in ops)
            {
                if (op.Equals("+"))
                {
                    var firstLast = records.Last();
                    var secondLast = records[records.Count - 2];
                    var newScore = firstLast + secondLast;
                    records.Add(newScore);
                    sum += newScore;
                }
                else if (op.Equals("D"))
                {
                    var prevScore = records.Last();
                    prevScore *= 2;
                    records.Add(prevScore);
                    sum += prevScore;
                }
                else if (op.Equals("C"))
                {
                    var prevScore = records.Last();
                    records.RemoveAt(records.Count - 1);
                    sum -= prevScore;
                }
                else
                {
                    var score = Convert.ToInt32(op);
                    records.Add(score);
                    sum += score;
                }
            }
            
            return sum;
        }
    }
}