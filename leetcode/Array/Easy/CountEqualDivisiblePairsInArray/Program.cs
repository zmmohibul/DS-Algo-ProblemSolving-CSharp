﻿int CountPairs(int[] nums, int k) {
    int count = 0;

    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = 1; j < nums.Length; j++)
        {
            if ((nums[i] == nums[j]) && ((i * j) % k == 0))
            {
                count += 1;
            }
        }
    }
    return count;
}