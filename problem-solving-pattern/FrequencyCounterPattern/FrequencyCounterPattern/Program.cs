bool same(List<int> list1, List<int> list2)
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
    printDictionary(freqList1);

    Console.WriteLine("freqList2: ");
    printDictionary(freqList2);

    foreach (var (key, value) in freqList1)
    {
        if (!freqList2.ContainsKey(key * key))
        {
            return false;
        }
        else
        {
            if (freqList2[key * key] != freqList1[key])
            {
                return false;
            }
        }
    }

    return true;
}

void printDictionary(IDictionary<int, int> dictionary)
{
    foreach (var (key, value) in dictionary)
    {
        Console.WriteLine($"{key}: {value}");
    }
}

Console.WriteLine(same(new List<int>() {1, 2, 2, 2, 3, 3}, new List<int>() {9, 1, 4, 4, 8, 9}));