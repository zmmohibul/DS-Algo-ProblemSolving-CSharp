using System.Collections.Generic;

TargetIndices(new int[] {5, 8, 3, 4, 2, 4, 3, 9, 3}, 4).ToList().ForEach(item => System.Console.WriteLine(item));


IList<int> TargetIndices(int[] nums, int target) {
    Array.Sort(nums);
    var result = new List<int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] == target)
        {
            result.Add(i);
            if (i + 1 < nums.Length) 
            {
                if (nums[i + 1] != target)
                {
                    break;
                }
            }
        }
    }
        
    return result;
}