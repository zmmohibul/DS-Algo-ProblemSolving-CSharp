using System;

namespace MinimumNumberOfMovesToSeatEveryOne
{
    public class Solution
    {
        public int MinMovesToSeat(int[] seats, int[] students) 
        {
            var moves = 0;

            Array.Sort(seats);
            Array.Sort(students);

            for (int i = 0; i < seats.Length; i++)
            {
                moves += Math.Max(seats[i], students[i]) - Math.Min(seats[i], students[i]);
            }

            return moves;
        }
    }
}