
int CountGoodRectangles(int[][] rectangles) 
{
    int maxLen = 0;
    int maxLenCount = 0;

    foreach (var rectangle in rectangles)
    {
        int minSide = GetMinOfTwoInt(rectangle[0], rectangle[1]);
        if (minSide > maxLen)
        {
            maxLen = minSide;
            maxLenCount = 1;
        }
        else if (minSide == maxLen)
        {
            maxLenCount += 1;
        }
    }

    return maxLenCount;
}   

int GetMinOfTwoInt(int n1, int n2)
{
    if (n1 < n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}