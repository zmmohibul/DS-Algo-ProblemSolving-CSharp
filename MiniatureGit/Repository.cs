using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MiniatureGit
{
    public class Repository
    {
        private static DirectoryInfo PWD = new DirectoryInfo(".");
        private static DirectoryInfo MINIATURE_GIT = new DirectoryInfo(Path.Join(PWD.FullName, ".minigit"));
        private static DirectoryInfo BLOBS = new DirectoryInfo(Path.Join(MINIATURE_GIT.FullName, "blobs"));
        public static void Init()
        {
            if (MINIATURE_GIT.Exists)
            {
                System.Console.WriteLine("This is already an initialized MinatureGit directory.");
                System.Environment.Exit(1);
            }

            System.Console.WriteLine(PWD.FullName);
            MINIATURE_GIT.Create();
        }

        public static async Task Add(string FileName)
        {
            BLOBS.Create();
            byte[] textInFile = await File.ReadAllBytesAsync(Path.Join(PWD.FullName, FileName));
            System.Console.WriteLine(textInFile);
            System.Console.WriteLine(Hash(textInFile));
            await File.WriteAllBytesAsync(Path.Join(BLOBS.FullName, Hash(textInFile)), textInFile);
        }


        private static string Hash(byte[] input)
        {
            using var sha1 = SHA1.Create();
            return Convert.ToHexString(sha1.ComputeHash(input));
        }


    }
}