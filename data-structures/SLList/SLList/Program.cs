using System;

namespace SLList
{
    class Program
    {
        static void Main(string[] args)
        {
            var SL = new SLList(15);
            SL.AddFirst(10);
            SL.AddFirst(5);
            SL.AddLast(20);
            Console.WriteLine(SL.GetLast());
            Console.WriteLine(SL.GetLengthRecursively());
        }
    }
}
