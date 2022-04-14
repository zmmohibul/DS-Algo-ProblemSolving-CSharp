int[] SmallerNumbersThanCurrent(int[] nums) 
{
    var answer = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        var currentNumber = nums[i];
        var numbersSmallerThanCurrentCount = 0;
        for (int j = 0; j < nums.Length; j++)
        {
            if (nums[j] < currentNumber)
            {
                numbersSmallerThanCurrentCount += 1;
            }

        }

        answer[i] = numbersSmallerThanCurrentCount;
    }

    return answer;
}