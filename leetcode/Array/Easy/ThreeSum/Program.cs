IList<IList<int>> ThreeSum(int[] nums) 
{
    var result = new List<IList<int>>();
    var d = new Dictionary<int, List<int>>();

    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (d.ContainsKey(nums[i]))
        {
            d[nums[i]].Add(nums[i]);
            var isEqual = false;
            foreach (var item in result)
            {
                isEqual = item.OrderBy(x => x).SequenceEqual(d[nums[i]].OrderBy(x => x));
                if (isEqual)
                {
                    break;
                }
            }
            if (!isEqual)
            {
                result.Add(d[nums[i]]);
            }
            d.Remove(nums[i]);
        }

        for (int j = i + 1; j < nums.Length; j++)
        {
            if (d.ContainsKey(nums[j]))
            {
                d[nums[j]].Add(nums[j]);
                var isEqual = false;
                foreach (var item in result)
                {
                    isEqual = item.OrderBy(x => x).SequenceEqual(d[nums[j]].OrderBy(x => x));
                    if (isEqual)
                    {
                        break;
                    }
                }
                if (!isEqual)
                {
                    result.Add(d[nums[j]]);
                }
                d.Remove(nums[j]);
            }

            var ijSum = nums[i] + nums[j];
            var numToFind = -ijSum;
            d[numToFind] = new List<int>{nums[i], nums[j]};
        }
    }

    return result;
}


ThreeSum(new int[] {-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0});
// ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});