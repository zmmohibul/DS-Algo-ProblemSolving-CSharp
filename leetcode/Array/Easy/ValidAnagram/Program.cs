﻿using System;

namespace ValidAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Solution sl = new Solution();
            System.Console.WriteLine(sl.IsAnagram("anagram", "nagaram"));
        }
    }
}
