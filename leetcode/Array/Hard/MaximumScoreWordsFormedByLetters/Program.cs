using System;

namespace MaximumScoreWordsFormedByLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            var words = new string[] {"dog","cat","dad","good"};
            var letters = new char[] {'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o'};
            var scores = new int[] {1,0,9,5,0,0,3,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0};

            System.Console.WriteLine(sl.MaxScoreWords(words, letters, scores));
        }
    }
}
