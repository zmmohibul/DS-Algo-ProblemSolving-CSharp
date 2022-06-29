IList<IList<int>> ThreeSum(int[] nums) 
{
    var result = new List<IList<int>>();
    var d = new Dictionary<int, List<List<int>>>();

    var numsAsHashSet = new HashSet<int>();
    foreach (var num in nums)
    {
        numsAsHashSet.Add(num);
    }
    var arrayFormOfNumsAsHashSet = new int[numsAsHashSet.Count];

    int i = 0;
    foreach (var item in numsAsHashSet)
    {
        arrayFormOfNumsAsHashSet[i] = item;
        i += 1;
    }

    foreach (var item in arrayFormOfNumsAsHashSet)
    {
        Console.Write($"{item} ");
    }
    System.Console.WriteLine();

    for (int j = 0; j < arrayFormOfNumsAsHashSet.Length - 1; j++)
    {
        for (int k = j + 1; k < arrayFormOfNumsAsHashSet.Length; k++)
        {
            var jkSum = arrayFormOfNumsAsHashSet[j] + arrayFormOfNumsAsHashSet[k];
            if (numsAsHashSet.Contains(-jkSum))
            {
                if (arrayFormOfNumsAsHashSet[j] != -jkSum && arrayFormOfNumsAsHashSet[k] != -jkSum)
                {
                    var r = new List<int> {arrayFormOfNumsAsHashSet[j], arrayFormOfNumsAsHashSet[k], -jkSum};
                    result.Add(r);
                }
            }
        }
    }

    return result;
}

// ThreeSum(new int[] {-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0});
ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});