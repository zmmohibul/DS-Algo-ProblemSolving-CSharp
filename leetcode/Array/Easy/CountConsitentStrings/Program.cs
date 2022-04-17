int CountConsistentStrings(string allowed, string[] words) 
{
    var allowedChars = new Dictionary<char, bool>();
    foreach (var c in allowed)
    {
        if (!allowedChars.ContainsKey(c))
        {
            allowedChars[c] = true;
        }
    }

    var count = 0;
    foreach (var word in words)
    {
        bool isWordConsistent = true;
        foreach (var c in word)
        {
            if (!allowedChars.ContainsKey(c))
            {
                isWordConsistent = false;
                break;
            }
        }

        if (isWordConsistent)
        {
            count += 1;
        }
    }

    return count;
}