IList<int> FindKDistantIndices(int[] nums, int key, int k)
{
    var keyIndices = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == key)
        {
            keyIndices.Add(i);
        }
    }

    var c = 0;
    var listToReturn = new List<int>();
    for (int i = 0; i < nums.Length; i++)
    {
        c += 1;
        foreach (var index in keyIndices)
        {
            if (Math.Abs(i - index) <= k)
            {
                listToReturn.Add(i);
                c += 1;
                break;
            }
        }
    }
    System.Console.WriteLine(c);
    return listToReturn;       
}

var result = FindKDistantIndices(new int[] {3,4,9,1,3,9,5}, 9, 1);
foreach (var index in result)
{
    Console.Write($"{index}, ");
}