using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToRoman
{
    public class Solution
    {
        public static string IntToRoman(int num) 
        {
            var result = new StringBuilder();
            var numAsList = new List<int>();
            while (num > 0)
            {
                numAsList.Add(num % 10);
                num = num / 10;
            }

            foreach (var n in numAsList)
            {
                Console.Write($"{n} ");
            }

            return result.ToString();
        }
    }
}