IList<IList<int>> ThreeSum(int[] nums) 
{
    var result = new List<IList<int>>();
    var itemIndexDict = new Dictionary<int, int>();
    var d = new Dictionary<int, List<List<int>>>();
    for (int i = 0, j = 1; i < nums.Length - 1; i++, j++)
    {
        var ijSum = nums[i] + nums[j];
        if (d.ContainsKey(nums[i]))
        {
            var pairs = d[nums[i]];
            foreach (var pair in pairs)
            {
                var pi = pair[0];
                var pj = pair[1];
                if (i != pi && j != pi && i != pj && j != pj)
                {
                    var l = new List<int>{nums[pi], nums[pj], nums[i]};
                    l.Sort();
                    var isEqual = false;
                    foreach (var item in result)
                    {
                        isEqual = item.SequenceEqual(l);
                        if (isEqual)
                        {
                            break;
                        }
                    }
                    if (!isEqual)
                    {
                        result.Add(l);
                    }
                }
            }
        }

        if (d.ContainsKey(nums[j]))
        {
            var pairs = d[nums[j]];
            foreach (var pair in pairs)
            {
                var pi = pair[0];
                var pj = pair[1];
                if (i != pi && j != pi && i != pj && j != pj)
                {
                    var l = new List<int>{nums[pi], nums[pj], nums[j]};
                    l.Sort();
                    var isEqual = false;
                    foreach (var item in result)
                    {
                        isEqual = item.SequenceEqual(l);
                        if (isEqual)
                        {
                            break;
                        }
                    }
                    if (!isEqual)
                    {
                        result.Add(l);
                    }
                }
            }
        }

        if (itemIndexDict.ContainsKey(-ijSum))
        {
            var ind = itemIndexDict[-ijSum];
            if (ind != i && ind != j)
            {
                var l = new List<int>{nums[i], nums[j], -ijSum};
                l.Sort();
                var isEqual = false;
                foreach (var item in result)
                {
                    isEqual = item.SequenceEqual(l);
                    if (isEqual)
                    {
                        break;
                    }
                }
                if (!isEqual)
                {
                    result.Add(l);
                }
            }
        }
        if (!d.ContainsKey(-ijSum))
        {
            d[-ijSum] = new List<List<int>>();
        }
        d[-ijSum].Add(new List<int>{i, j});
        itemIndexDict[nums[i]] = i;
        itemIndexDict[nums[j]] = j;

    }

    return result;
}


ThreeSum(new int[] {-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0});
// ThreeSum(new int[] {-1, 0, 1, 2, -1, -4});