using System;

namespace ReplaceElementWithGreatesElementOnRight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            var ar = sl.ReplaceElements(new int[] {17,18,5,4,6,1});
            foreach (var n in ar)
            {
                Console.Write($"{n} ");
            }
            System.Console.WriteLine();
        }
    }
}
