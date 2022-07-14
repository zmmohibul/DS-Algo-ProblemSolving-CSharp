using System;
using System.Collections.Generic;

namespace ListSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListSearch ls = new ListSearch();
            var l = new List<int>(){1, 2, 3, 4, 5};
            System.Console.WriteLine(ls.LinearSearch(l, 49));
        }
    }
}
