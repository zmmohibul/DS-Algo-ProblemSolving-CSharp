System.Console.WriteLine(FindGCD(new int[] {2,5,6,9,10}));
System.Console.WriteLine(FindGCD(new int[] {7,5,6,8,3}));
System.Console.WriteLine(FindGCD(new int[] {3,3}));



int FindGCD(int[] nums) 
{
    int gcd = 0;
    int min = int.MaxValue;
    int max = int.MinValue;

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] > max)
        {
            max = nums[i];
        }

        if (nums[i] < min) 
        {
            min = nums[i];
        }
    }

    while (true)
    {
        if (min == 0 || max == 0)
        {
            break;
        }

        int rem = max % min;
        max = min;
        min = rem;
    }

    return max;
}