

ThreeSum(new int[] {-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0});

public IList<IList<int>> ThreeSum(int[] nums) {
        var result = new List<IList<int>>();

        for (int i = 0; i < nums.Length - 2; i++)
        {
            for (int j = i + 1; j < nums.Length - 1; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        var r = new List<int>{nums[i], nums[j], nums[k]};
                        var foundTriplet = false;
                        foreach (var item in result)
                        {
                            // if (item.Equals(r))
                            // {
                            //     foundTriplet = true;
                            //     break;
                            // }
                            if (item.Contains(nums[i]) && item.Contains(nums[j]) && item.Contains(nums[k]))
                            {
                                foundTriplet = true;
                                break;
                            }
                        }
                        if (!foundTriplet)
                        {
                            result.Add(r);
                        }
                        // result.Add(new List<int>{nums[i], nums[j], nums[k]});
                    }
                }
            }
        }

        return result;
    }