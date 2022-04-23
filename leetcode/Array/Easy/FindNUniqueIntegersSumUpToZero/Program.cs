SumZero(5).ToList().ForEach(item => System.Console.Write($"{item}, "));

int[] SumZero(int n) 
{
    int halfN = n / 2;
    int[] arr = new int[n];
    int i = 0;
    while (i < n - 1)
    {
        arr[i] = halfN;
        arr[i + 1] = -halfN;
        i += 2;
        halfN -= 1;
    }
    if (n % 2 != 0)
    {
        arr[n - 1] = 0;
    }
    return arr;
}