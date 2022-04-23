System.Console.WriteLine(PrefixCount(new string[]{"pay","attention","practice","attend"}, "at"));

int PrefixCount(string[] words, string pref) 
{
    int i = 0;
    int j = 0;
    
    int wordCount = 0;
    
    foreach (var word in words)
    {
        bool samePref = true;
        if (word.Length < pref.Length)
        {
            continue;
        }
        while (j < pref.Length && i < word.Length)
        {
            if (!word[i].Equals(pref[j]))
            {
                samePref = false;
                break;
            }
            
            i += 1;
            j += 1;
        }
        i = 0;
        j = 0;
        
        if (samePref)
        {
            wordCount += 1;
        }
    }
    return wordCount;
}