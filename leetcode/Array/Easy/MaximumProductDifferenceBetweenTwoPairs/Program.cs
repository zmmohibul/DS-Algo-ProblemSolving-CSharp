int[] nums = new int[] {5,6,2,7,4};
System.Console.WriteLine(MaxProductDifference(nums));

int MaxProductDifference(int[] nums)
{
    Array.Sort(nums);

    int max1 = nums[nums.Length - 1];
    int max2 = nums[nums.Length - 2];

    int min1 = nums[0];
    int min2 = nums[1];
        
    return (max1 * max2) - (min1 * min2);
}   