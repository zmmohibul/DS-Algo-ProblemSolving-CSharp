using System;

namespace MiniatureGit
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArg = args[0];
            if (firstArg.Equals("init")) 
            {
                Repository.Init();
            }
            Console.WriteLine("Hello World!");
        }
    }
}
