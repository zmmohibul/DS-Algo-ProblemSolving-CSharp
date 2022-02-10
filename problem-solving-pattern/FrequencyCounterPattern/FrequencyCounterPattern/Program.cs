﻿bool Same(List<int> list1, List<int> list2)
{
    if (list1.Count != list2.Count)
    {
        return false;
    }
    
    var freqList1 = new Dictionary<int, int>();
    var freqList2 = new Dictionary<int, int>();

    for (var i = 0; i < list1.Count; i++)
    {
        if (!freqList1.ContainsKey(list1[i]))
        {
            freqList1[list1[i]] = 1;
        }
        else
        {
            freqList1[list1[i]] += 1;
        }
        
        if (!freqList2.ContainsKey(list2[i]))
        {
            freqList2[list2[i]] = 1;
        }
        else
        {
            freqList2[list2[i]] += 1;
        }
    }

    Console.WriteLine("freqList1: ");
    PrintDictionary(freqList1);

    Console.WriteLine("freqList2: ");
    PrintDictionary(freqList2);

    foreach (var (key, value) in freqList1)
    {
        if (!freqList2.ContainsKey(key * key))
        {
            return false;
        }
        
        if (freqList2[key * key] != freqList1[key])
        {
            return false;
        }
    }

    return true;
}



bool ValidAnagram(string s1, string s2)
{
    if (s1.Length != s2.Length)
    {
        return false;
    }
    
    var s1CharFreq = new Dictionary<char, int>();
    var s2CharFreq = new Dictionary<char, int>();

    for (int i = 0; i < s1.Length; i++)
    {
        if (!s1CharFreq.ContainsKey(s1[i]))
        {
            s1CharFreq[s1[i]] = 1;
        }
        else
        {
            s1CharFreq[s1[i]] += 1;
        }
        
        if (!s2CharFreq.ContainsKey(s2[i]))
        {
            s2CharFreq[s2[i]] = 1;
        }
        else
        {
            s2CharFreq[s2[i]] += 1;
        }
    }

    Console.WriteLine("s1CharFreq:");
    PrintDictionary(s1CharFreq);
    
    Console.WriteLine("s2CharFreq:");
    PrintDictionary(s2CharFreq);

    foreach (var (key, value) in s1CharFreq)
    {
        if (!s2CharFreq.ContainsKey(key))
        {
            return false;
        }

        if (s2CharFreq[key] != value)
        {
            return false;
        }
    }
    
    return true;
}



bool DigitsHaveSameFrequency(int n1, int n2)
{
    var n1Freq = new Dictionary<int, int>();
    while (n1 != 0)
    {
        var digit = n1 % 10;
        if (!n1Freq.ContainsKey(digit))
        {
            n1Freq[digit] = 1;
        }
        else
        {
            n1Freq[digit] += 1;
        }

        n1 /= 10;
    }
    
    var n2Freq = new Dictionary<int, int>();
    while (n2 != 0)
    {
        var digit = n2 % 10;
        if (!n2Freq.ContainsKey(digit))
        {
            n2Freq[digit] = 1;
        }
        else
        {
            n2Freq[digit] += 1;
        }

        n2 /= 10;
    }

    foreach (var (key, value) in n1Freq)
    {
        if (!n2Freq.ContainsKey(key))
        {
            return false;
        }

        if (n2Freq[key] != value)
        {
            return false;
        }
    }

    Console.WriteLine("n1Freq: ");
    PrintDictionary(n1Freq);
    Console.WriteLine("n2Freq: ");
    PrintDictionary(n2Freq);

    return true;
}

bool AreThereDuplicates(List<int> numbers)
{
    var numbersFreq = new Dictionary<int, int>();
    foreach (var number in numbers)
    {
        if (!numbersFreq.ContainsKey(number))
        {
            numbersFreq[number] = 1;
        }
        else
        {
            return true;
        }
    }

    return false;
}

void PrintDictionary<T>(IDictionary<T, int> dictionary)
{
    foreach (var (key, value) in dictionary)
    {
        Console.WriteLine($"{key}: {value}");
    }
}

// Console.WriteLine(Same(new List<int>() {1, 2, 2, 2, 3, 3}, new List<int>() {9, 1, 4, 4, 8, 9}));
// Console.WriteLine(ValidAnagram("ababcaa", "caabbaw"));
// Console.WriteLine(DigitsHaveSameFrequency(112231323, 123123123));
Console.WriteLine(AreThereDuplicates(new List<int>() {1, 2, 3, 4, 5,}));