using System;
using System.Collections.Generic;

namespace MiniatureGit
{
    [Serializable]
    public class Commit
    {
        public DateTime CommitedAt { get; } = DateTime.Now;
        public string CommitMessage { get; set; }
        public string Parent { get; set; }
        public Dictionary<string, string> BlobShaMap { get; set; }

        public Commit()
        {
            CommitMessage = "Initial Commit";
            Parent = null;
            BlobShaMap = new Dictionary<string, string>();
        }
        
        
        
        


        
        
        
        
    }
}