IList<IList<int>> ThreeSum(int[] nums) 
{
    var result = new List<IList<int>>();

    for (int i = 0; i < nums.Length - 2; i++)
    {
        for (int j = i + 1; j < nums.Length - 1; j++)
        {
            for (int k = j + 1; k < nums.Length; k++)
            {
                var n1 = nums[i];
                var n2 = nums[j];
                var n3 = nums[k];
                var n4 = n1 + n2 + n3;

                if (n4 == 0)
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
                        r.Sort();
                        var it = item.ToList();
                        it.Sort();
                        var eqC = 0;
                        for (int x = 0; x < r.Count; x++)
                        {
                            if (r[x] == it[x])
                            {
                                eqC += 1;
                            }
                        }
                        if (eqC == 3)
                        {
                            foundTriplet = true;
                            break;
                        }
                    }
                    if (!foundTriplet)
                    {
                        r.Sort();
                        result.Add(r);
                    }
                }
            }
        }
    }

    return result;
}

ThreeSum(new int[] {-4,-2,1,-5,-4,-4,4,-2,0,4,0,-2,3,1,-5,0});