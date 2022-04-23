System.Console.WriteLine(FindNumbers(new int[] {12,345,2,6,7896}));
int FindNumbers(int[] nums)
{
    int count = 0;
    foreach (int num in nums)
    {
        int numberOfDigits = 0;
        int tempNum = num;
        while (tempNum > 0)
        {
            numberOfDigits += 1;
            tempNum /= 10;
        }
        
        if (numberOfDigits % 2 == 0)
        {
            count += 1;
        }
    }
    
    return count;
    
}