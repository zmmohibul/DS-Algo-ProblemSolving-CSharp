int MaxArea(int[] height) 
{
    int maxArea = 0;

    for (int i = 0; i < height.Length - 1; i++)
    {
        for (int j = 0; j < height.Length; j++)
        {
            var jCurrentArea = (j - i) * (height[i] < height[j] ? height[i] : height[j]);
            if (jCurrentArea > maxArea)
            {
                maxArea = jCurrentArea;
            }
        }
    }

    return maxArea;   
}

System.Console.WriteLine(MaxArea(new int[] {1,8,6,2,5,4,8,3,7}));