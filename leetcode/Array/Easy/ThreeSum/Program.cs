IList<IList<int>> ThreeSum(int[] nums) 
{
    var result = new List<IList<int>>();
    var d = new Dictionary<int, List<List<int>>>();

    Array.Sort(nums);

    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            var ijSum = nums[i] + nums[j];
            if (BinarySearch(nums, -ijSum, j + 1))
            {
                var r = new List<int>{nums[i], nums[j], -ijSum};
                result.Add(r);
            }
            while (j < nums.Length - 1 && nums[j] == nums[j+1])
            {
                j++;
            }
        }
        while (i < nums.Length - 1 && nums[i] == nums[i+1])
        {
            i++;
        }
    }
    

    return result;
}

bool BinarySearch(int[] nums, int target, int left)
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

System.Console.WriteLine(BinarySearch(new int[] {1}, 1, 0));

ThreeSum(new int[] {-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0});
// ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});