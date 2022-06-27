int CountKDifference(int[] nums, int k) 
{
    var count = 0;
    var numsFreq = new Dictionary<int, int>();
    foreach (var num in nums)
    {
        if (!numsFreq.ContainsKey(num))
        {
            numsFreq[num] = 1;
        }
        else
        {
            numsFreq[num] += 1;
        }
    }

    foreach (var (key, value) in numsFreq)
    {
        Console.Write($"{key}: {value}, ");
    }
    System.Console.WriteLine();

    foreach (var num in nums)
    {
        var diff1 = num + k;
        var diff2 = num - k;
        Console.WriteLine($"{num}: ({diff1}, {diff2})");

        if (numsFreq.ContainsKey(diff1))
        {
            count += numsFreq[diff1];
        }

        if (numsFreq.ContainsKey(diff2))
        {
            count += numsFreq[diff2];
        }

        numsFreq[num] -= 1;
        foreach (var (key, value) in numsFreq)
        {
            Console.Write($"{key}: {value}, ");
        }
        System.Console.WriteLine();
    }

    return count;
}

System.Console.WriteLine(CountKDifference(new int[] {3, 2, 1, 5, 4}, 2));