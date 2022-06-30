IList<IList<int>> FourSum(int[] nums, int target) 
{
    var result = new List<IList<int>>();

    Array.Sort(nums);
    for (int i = 0; i < nums.Length - 2; i++)
    {
        for (int j = i + 1; j < nums.Length - 1; j++)
        {
            for (int k = j + 1; k < nums.Length; k++)
            {
                long ijkSum = nums[i] + nums[j] + nums[k];
                long numToFind = ijkSum - target;
                numToFind = -numToFind;
                if (BinarySearch(nums, numToFind, k + 1))
                {
                    var r = new List<int> {nums[i], nums[j], nums[k], (int) numToFind};
                    result.Add(r);
                }
                while (k < nums.Length -1 && nums[k] == nums[k + 1])
                {
                    k += 1;
                }
            }
            while (j < nums.Length -1 && nums[j] == nums[j + 1])
            {
                j += 1;
            }
        }
        while (i < nums.Length - 1 && nums[i] == nums[i + 1])
        {
            i += 1;
        }
    }

    return result;
}

bool BinarySearch(int[] nums, long target, int left)
{
    int right = nums.Length - 1;
    while (right >= left)
    {
        int mid = (left + right) / 2;
        if (nums[mid] == target) 
        {
            return true;
        }

        if (target > nums[mid])
        {
            left = mid + 1;
        }
        else
        {
            right = mid - 1;
        }
    }
    
    return false;
}