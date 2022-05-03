using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniatureGit
{
    public class Repository
    {
        public static readonly DirectoryInfo PWD = new DirectoryInfo(".");
        public static readonly DirectoryInfo MiniatureGit = new DirectoryInfo(Path.Join(PWD.FullName, ".minigit"));
        public static readonly DirectoryInfo Blobs = new DirectoryInfo(Path.Join(MiniatureGit.FullName, "blobs"));
        public static readonly DirectoryInfo Commits = new DirectoryInfo(Path.Join(MiniatureGit.FullName, "commits"));
        public static readonly DirectoryInfo Branches = new DirectoryInfo(Path.Join(MiniatureGit.FullName, "branches"));
        public static readonly string Head = Path.Join(MiniatureGit.FullName, "HEAD");
        public static readonly string MasterBranch = Path.Join(Branches.FullName, "master");
        public static readonly string StagingAreaFilePath = Path.Join(MiniatureGit.FullName, "StagingArea");

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

            var firstCommitHash = await Utils.WriteObjectAndGetObjectHashAsync<Commit>(firstcommit, Commits.FullName);

            await File.WriteAllTextAsync(Head, firstCommitHash);
            await File.WriteAllTextAsync(MasterBranch, firstCommitHash);
        }

        public static async Task Add(string FileName)
        {
            var fileContent = await File.ReadAllBytesAsync(Path.Join(Repository.PWD.FullName, FileName));
            var fileContentSha = Utils.GetSha1(fileContent);
            if (!File.Exists(StagingAreaFilePath))
            {
                StagingArea sa = new StagingArea();
                sa.Add(FileName, fileContentSha);
                await Utils.WriteObject(sa, StagingAreaFilePath);
            }
            else
            {
                StagingArea sa = await Utils.ReadObjectAsync<StagingArea>(StagingAreaFilePath);
                sa.Add(FileName, fileContentSha);
                await Utils.WriteObject(sa, StagingAreaFilePath);
            }
        }

        public static async Task AddAll()
        {
            var files = Directory.GetFiles(PWD.FullName);

            foreach (var file in files)
            {
                System.Console.WriteLine(file);
            }
        }
    }
}