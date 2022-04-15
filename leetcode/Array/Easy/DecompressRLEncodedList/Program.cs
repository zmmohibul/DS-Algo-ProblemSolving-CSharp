int[] DecompressRLElist(int[] nums)
{
    var answer = new List<int>();

    for (int i = 0; i < nums.Length; i += 2)
    {
        var freq = nums[i];
        var val = nums[i + 1];

        for (int j = 0; j < freq; j++)
        {
            answer.Add(val);
        }
    }


    return answer.ToArray();
        
}

var nums = new int[] {1,2,3,4};

DecompressRLElist(nums).ToList().ForEach(num => Console.Write($"{num}, "));