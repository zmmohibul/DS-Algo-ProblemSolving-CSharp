int SumOddLengthSubarrays(int[] arr) 
{
    var sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
        if ((i + 1) != 1 && (i + 1) % 2 != 0)
        {
            var numberOfSubarrays = arr.Length - (i - 1);
            var subSum = 0;
            for (int j = 0; j <= i; j++)
            {
                subSum += arr[j];
            }

            sum += subSum;

            for (int j = 0, k = i + 1; k < arr.Length; k++, j++)
            {
                subSum -= arr[j];
                subSum += arr[k];
                sum += subSum;
            }
        }
    }

    return sum;
}


System.Console.WriteLine(SumOddLengthSubarrays(new int[]{1,4,2,5,3}));