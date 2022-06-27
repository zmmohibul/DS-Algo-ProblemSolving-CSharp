int MaxArea(int[] height) 
{
    if (height.Length < 2)
    {
        return 0;
    }

    int maxArea = 0;

    int i = 0;
    int j = height.Length - 1;
    while (true)
    {
        if (i == j)
        {
            break;
        }

        int area = 0;
        if (height[i] < height[j])
        {
            area = (j - i) * height[i];
            i += 1;
        }
        else
        {
            area = (j - i) * height[j];
            j -= 1;
        }

        maxArea = area > maxArea ? area : maxArea;
    }

    return maxArea;   
}

System.Console.WriteLine(MaxArea(new int[] {1,8,6,2,5,4,8,3,7}));
System.Console.WriteLine(MaxArea(new int[] {1,1}));
