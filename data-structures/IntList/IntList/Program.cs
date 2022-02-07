using System;

namespace IntList
{
    class Program
    {
        static void Main(string[] args)
        {
            var L = new IntList(5, null);
            L.Rest = new IntList(10, null);
            L.Rest.Rest = new IntList(15, null);
            L.Rest.Rest.Rest = new IntList(20, null);
            L.Rest.Rest.Rest.Rest = new IntList(25, null);
            L.Rest.Rest.Rest.Rest.Rest = new IntList(30, null);

            Console.WriteLine(L.Length());
            Console.WriteLine(L.LengthIterative());
            Console.WriteLine(L.Get(3));
            Console.WriteLine(L.GetIterative(4));
        }
    }
}