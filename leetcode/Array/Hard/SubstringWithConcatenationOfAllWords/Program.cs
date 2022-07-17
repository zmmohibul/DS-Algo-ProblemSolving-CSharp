using System;

namespace SubstringWithConcatenationOfAllWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            var words = new string[] {"bar","foo","the"};
            var result = sl.FindSubstring("barfoofoobarthefoobarman", words);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            System.Console.WriteLine();
        }
    }
}
