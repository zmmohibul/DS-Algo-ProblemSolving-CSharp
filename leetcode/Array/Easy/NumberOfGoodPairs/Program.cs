int NumIdenticalPairs(int[] nums) 
{
    var numberOfGoodPairs = 0;

    var dict = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (!dict.ContainsKey(nums[i]))
        {
            dict[nums[i]] = 0;
        }
        else
        {
            dict[nums[i]] += 1;
        }
    }

    foreach (var val in dict.Values)
    {
        numberOfGoodPairs += ((val * (val + 1)) / 2);
    }

    return numberOfGoodPairs;
}

System.Console.WriteLine(NumIdenticalPairs(new int[] {1,2,3,1,1,3}));
System.Console.WriteLine(NumIdenticalPairs(new int[] {1,1,1,1}));
