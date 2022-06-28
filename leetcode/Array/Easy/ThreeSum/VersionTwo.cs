namespace ThreeSum
{
    public class VersionTwo
    {
        public static IList<IList<int>> ThreeSum(int[] nums) 
        {
            var result = new List<IList<int>>();
            var d = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var ijSum = nums[i] + nums[j];
                    var numToFind = -ijSum;
                    if (d.ContainsKey(numToFind))
                    {
                        d[numToFind].Add(numToFind);
                        result.Add(d[numToFind]);
                        d.Remove(numToFind);
                    }
                    else
                    {
                        var r = new List<int>{nums[i], nums[j]};
                        d[numToFind] = r;
                    }
                }
            }

            return result;
        }
    }
}