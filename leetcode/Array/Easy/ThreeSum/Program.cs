IList<IList<int>> ThreeSum(int[] nums) 
{
    var result = new List<IList<int>>();
    var d = new Dictionary<int, List<List<int>>>();

    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (d.ContainsKey(nums[i]))
        {
            foreach (var pair in d[nums[i]])
            {
                if (i != pair[0] && i != pair[1])
                {
                    var r = new List<int>{nums[pair[0]], nums[pair[1]], nums[i]};
                    r.Sort();
                    var isEqual = false;
                    foreach (var rs in result)
                    {
                        isEqual = rs.SequenceEqual(r);
                        if (isEqual)
                        {
                            break;
                        }
                    }
                    if (!isEqual)
                    {
                        result.Add(r);
                    }
                }
            }
        }

        for (int j = i + 1; j < nums.Length; j++)
        {
            if (d.ContainsKey(nums[j]))
            {
                foreach (var pair in d[nums[j]])
                {
                    if (j != pair[0] && j != pair[1])
                    {
                        var r = new List<int>{nums[pair[0]], nums[pair[1]], nums[j]};
                        r.Sort();
                        var isEqual = false;
                        foreach (var rs in result)
                        {
                            isEqual = rs.SequenceEqual(r);
                            if (isEqual)
                            {
                                break;
                            }
                        }
                        if (!isEqual)
                        {
                            result.Add(r);
                        }
                    }
                }
            }

            var ijSum = nums[i] + nums[j];
            if (!d.ContainsKey(-ijSum))
            {
                d[-ijSum] = new List<List<int>>();
            }
            d[-ijSum].Add(new List<int>{i, j});
        }
    }

    return result;
}


ThreeSum(new int[] {-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0});
// ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});