﻿using System;
using System.Threading.Tasks;

namespace MiniatureGit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var firstArg = args[0];
            if (firstArg.Equals("init")) 
            {
                Repository.Init();
            }
            else if (firstArg.Equals("add")) 
            {
                var fileToAdd = args[1];
                await Repository.Add(fileToAdd);
                
            }
            Console.WriteLine("Hello World!");
        }
    }
}
