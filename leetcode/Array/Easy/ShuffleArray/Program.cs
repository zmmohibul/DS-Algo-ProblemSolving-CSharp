int[] Shuffle(int[] nums, int n) 
{
    var i = 1;
    while (i < nums.Length - 2) 
    {
        swap(nums, i, n);
        var j = n;
        while (j > i + 1) 
        {
            swap(nums, j, j - 1);
            j--;
        }

        i += 2;
        n += 1;

    }

    return nums;
}

void swap(int[] nums, int i, int j)
{
    var temp = nums[j];
    nums[j] = nums[i];
    nums[i] = temp;
}

var nums = new int[] {1,2,3,4,4,3,2,1};
var result = Shuffle(nums, 4);

result.ToList().ForEach(item => Console.Write($"{item}, "));

