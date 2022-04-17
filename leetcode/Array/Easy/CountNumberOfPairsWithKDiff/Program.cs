int CountKDifference(int[] nums, int k) 
{
    var count = 0;

    for (int i = 0; i < nums.Length - 1; i++)        
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if (Math.Abs(nums[i] - nums[j]) == k)
            {
                count += 1;
            }
        }
    }

    return count;
}