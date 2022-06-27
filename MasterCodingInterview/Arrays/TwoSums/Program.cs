int[] FindTargetPair(int[] arr, int target)
{
    int[] targetPair = new int[2];

    for (int i = 0; i < arr.Length - 1; i++)
    {
        int numberToFind = target - arr[i];
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] == numberToFind)
            {
                targetPair[0] = i;
                targetPair[1] = j;
                return targetPair;
            }
        }
    }

    return null;
}

var targetPair = FindTargetPair(new int[] {1, 3, 7, 9, 2}, 92);
if (targetPair != null)
{
    System.Console.WriteLine($"Target Pair: {targetPair[0]}, {targetPair[1]}");
}