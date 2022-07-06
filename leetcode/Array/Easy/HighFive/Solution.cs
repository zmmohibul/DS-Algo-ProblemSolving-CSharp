using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighFive
{
    public class Solution
    {
        public int[][] HighFive(int[][] items) 
        {
            var studentScores = new Dictionary<int, List<int>>();

            foreach (var item in items)
            {
                var studentId = item[0];
                var score = item[1];
                if (!studentScores.ContainsKey(studentId))
                {
                    studentScores[studentId] = new List<int>();
                }
                studentScores[studentId].Add(score);
            }

            int[][] result = new int[studentScores.Count()][];
            int ri = 0;
            
            var students = studentScores.Keys.ToArray();
            Array.Sort(students);

            foreach (var student in students)
            {
                var scores = studentScores[student];
                scores.Sort();

                int j = scores.Count - 1;
                int numberOfScoresCalculated = 0;
                int sum = 0;
                while (j >= 0 && numberOfScoresCalculated < 5)
                {
                    sum += scores[j];
                    j -= 1;
                    numberOfScoresCalculated += 1;
                }

                int average = sum / 5;

                result[ri] = new int[] {student, average};
                ri += 1;
            }
            
            return result;
        }
    }
}