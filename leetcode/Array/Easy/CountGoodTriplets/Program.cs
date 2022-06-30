int CountGoodTriplets(int[] arr, int a, int b, int c)
{
    var count = 0;
    for (int i = 0; i < arr.Length - 2; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                {
                    count += 1;
                }
            }
        }
    }

    return count;
}