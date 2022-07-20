using System;
using System.Collections.Generic;

namespace SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var sl = new Solution();
            var numbers = new HashSet<int> {1, 3, 4, 5};
            System.Console.WriteLine(sl.SubsetSumWays(numbers, 7));
        }
    }
}
