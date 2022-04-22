System.Console.WriteLine(MaxProduct(new int[] {3,4,5,2}));

int MaxProduct(int[] nums) 
{
    int maxProduct = 0;

    for (int i = 0; i < nums.Length - 1; i++)
    {
        for (int j = i + 1; j < nums.Length; j++)
        {
            if ((nums[i] - 1) * (nums[j] - 1) > maxProduct)
            {
                maxProduct = (nums[i] - 1) * (nums[j] - 1);
            }
        }
    }

    return maxProduct;
}