using System.IO;

namespace MiniatureGit
{
    public class Repository
    {
        private static DirectoryInfo CURR_DIR = new DirectoryInfo(".");
        private static DirectoryInfo MINIATURE_GIT = new DirectoryInfo(Path.Join(CURR_DIR.FullName, ".minigit"));
        private static DirectoryInfo BLOOBS = new DirectoryInfo(Path.Join(MINIATURE_GIT.FullName, "bloobs"));
        public static void Init()
        {
            if (MINIATURE_GIT.Exists)
            {
                System.Console.WriteLine("This is already an initialized MinatureGit directory.");
                System.Environment.Exit(1);
            }

            System.Console.WriteLine(CURR_DIR.FullName);
            MINIATURE_GIT.Create();
        }

    }
}