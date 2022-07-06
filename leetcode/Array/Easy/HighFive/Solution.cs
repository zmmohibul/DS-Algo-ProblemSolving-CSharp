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
            // Instantiate a Dictionary of (int, List<int>)
            // This dictionary will keep track of list of scores for each student
            var studentScores = new Dictionary<int, List<int>>();

            // Iterate over each score in items and add score to student's id in Dictionary  
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
            int i = 0;
            // Iterate over each (student, scores) in dictionary
            foreach (var (student, score) in studentScores)
            {
                // For each student sort the scores list
                score.Sort();

                // Calculate the average of last 5 items in list
                int sum = 0;
                int numberOfScoresCalculated = 0;
                int j = score.Count - 1;
                while (j >= 0 && numberOfScoresCalculated < 5)
                {
                    sum += score[j];
                    j -= 1;
                    numberOfScoresCalculated += 1;
                }
                int average = sum / 5;

                // Add (student, average) to result array
                result[i] = new int[2]{student, average};
                i += 1;
            }
            
            // Return result array;
            return result;
        }
    }
}