int CountPairs(int[] nums, int k) {
    int count = 0;
    var dict = new Dictionary<int, List<int>>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (!dict.ContainsKey(nums[i]))
        {
            dict[nums[i]] = new List<int>();
        }
        else
        {
            foreach (var index in dict[nums[i]])
            {
                if ((i * index) % k == 0)
                {
                    count += 1;
                }
            }
        }
        dict[nums[i]].Add(i);
        // for (int j = i+1; j < nums.Length; j++)
        // {
        //     if ((nums[i] == nums[j]) && ((i * j) % k == 0))
        //     {
        //         count += 1;
        //     }
        // }
    }
    // foreach (var (num, indices) in dict)
    // {
    //     Console.Write($"{num}: ");
    //     foreach (var index in indices)
    //     {
    //         Console.Write($"{index} ");
    //     }
    //     System.Console.WriteLine();
    // }
    // System.Console.WriteLine();
    return count;
}

System.Console.WriteLine(CountPairs(new int[] {3,1,2,2,2,1,3}, 2));;