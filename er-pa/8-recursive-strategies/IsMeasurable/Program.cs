using System;
using System.Collections.Generic;

namespace IsMeasurable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var weights = new List<int>{1, 1, 18, 7};
            Solution sl = new Solution();
            System.Console.WriteLine(sl.IsMeasurable(weights, 4));
        }
    }
}
