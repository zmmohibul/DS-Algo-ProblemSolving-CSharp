bool IsPermutation(string s1, string s2)
{
    if (s1.Length != s2.Length)
    {
        return false;
    }
    
    var s1CharFreq = GetCharFreqOfString(s1);
    var s2CharFreq = GetCharFreqOfString(s2);

    // PrintDictionary(s1CharFreq);
    // PrintDictionary(s2CharFreq);

    foreach (var (key, value) in s1CharFreq)
    {
        if (!s2CharFreq.ContainsKey(key))
        {
            return false;
        }
        else
        {
            if (value != s2CharFreq[key])
            {
                return false;
            }
        }
    }

    return true;
}

Dictionary<char, int> GetCharFreqOfString(string s)
{
    var sCharFreq = new Dictionary<char, int>();
    foreach (var c in s)
    {
        if (!sCharFreq.ContainsKey(c))
        {
            sCharFreq[c] = 1;
        }
        else
        {
            sCharFreq[c] += 1;
        }
    }

    return sCharFreq;
}

void PrintDictionary<K, V>(Dictionary<K, V> dict)
{
    foreach (var (key, value) in dict)
    {
        Console.Write($"{key}: {value}, ");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine(IsPermutation("abcddec", "ddeabcc"));