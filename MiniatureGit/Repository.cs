using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniatureGit
{
    public class Repository
    {
        private static readonly DirectoryInfo PWD = new DirectoryInfo(".");
        
        private static readonly DirectoryInfo MiniatureGit = new DirectoryInfo(Path.Join(PWD.FullName, ".minigit"));
        
        private static readonly DirectoryInfo Blobs = new DirectoryInfo(Path.Join(MiniatureGit.FullName, "blobs"));
        private static readonly DirectoryInfo Commits = new DirectoryInfo(Path.Join(MiniatureGit.FullName, "commits"));
        private static readonly DirectoryInfo Branches = new DirectoryInfo(Path.Join(MiniatureGit.FullName, "branches"));

        private static readonly string Head = Path.Join(MiniatureGit.FullName, "HEAD");
        private static readonly string MasterBranch = Path.Join(Branches.FullName, "master");



        
        

        public static async Task Init()
        {
            if (MiniatureGit.Exists)
            {
                System.Console.WriteLine("This is already an initialized MinatureGit directory.");
                System.Environment.Exit(1);
            }

            MiniatureGit.Create();
            Blobs.Create();
            Commits.Create();
            Branches.Create();

            var firstcommit = new Commit();

            var firstCommitHash = await Utils.WriteObjectAndGetObjectHashAsync(firstcommit, Commits.FullName);

            await File.WriteAllTextAsync(Head, firstCommitHash);
            await File.WriteAllTextAsync(MasterBranch, firstCommitHash);
        }

        public static async Task Add(string FileName)
        {
            Blobs.Create();
            byte[] textInFile = await File.ReadAllBytesAsync(Path.Join(PWD.FullName, FileName));
            System.Console.WriteLine(textInFile);
            System.Console.WriteLine(Hash(textInFile));
            await File.WriteAllBytesAsync(Path.Join(Blobs.FullName, Hash(textInFile)), textInFile);
        }

        public static async Task Commit()
        {
            var commit = new Commit();
            commit.BlobShaMap["rand.txt"] = "blah blah blah";
            commit.BlobShaMap["rand2.txt"] = "lah lah lah";

            if (!Commits.Exists)
            {
                Commits.Create();
            }

            var json = DataSerializer.GetJson(commit);
            var jsonByte = UnicodeEncoding.ASCII.GetBytes(json);
            var jsonHash = Hash(jsonByte);
            
            await DataSerializer.Serialize(json, Path.Join(Commits.FullName, jsonHash));
        }

        private static string Hash(byte[] input)
        {
            using var sha1 = SHA1.Create();
            return Convert.ToHexString(sha1.ComputeHash(input));
        }

    }
}