using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MiniatureGit
{
    public class StagingArea
    {
        public Dictionary<string, string> FilesStagedForAddition { get; set; }

        public StagingArea()
        {
            FilesStagedForAddition = new Dictionary<string, string>();
        }
        
        

        public void Add(string FileName, string FileContentSha)
        {
            FilesStagedForAddition[FileName] = FileContentSha;
        }

        public void ShowFilesStagedForAddition()
        {
            foreach (var (key, value) in FilesStagedForAddition)
            {
                System.Console.WriteLine($"{key}: {value}");
            }
        }
        
    }
}