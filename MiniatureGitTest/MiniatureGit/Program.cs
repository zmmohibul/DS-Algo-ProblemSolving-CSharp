using System;
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
                await Repository.Init();
            }
            else if (firstArg.Equals("add")) 
            {
                var fileToAdd = args[1];
                if (firstArg.Equals("."))
                {
                    await Repository.AddAll();
                }
                // await StagingArea.Add(fileToAdd);
                // foreach (var (key, value) in StagingArea.FilesStagedForAddition)
                // {
                //     System.Console.WriteLine($"{key}: {value}");
                // }
                await Repository.Add(fileToAdd);
            }
            else if (firstArg.Equals("commit"))
            {
                // await Repository.Commit();
            }
        }
    }
}
