int Power(int baseNum, int exponent)
{
    if (exponent == 0)
    {
        return 1;
    }

    return baseNum * Power(baseNum, exponent - 1);
}

int Factorial(int n)
{
    if (n == 0)
    {
        return 1;
    }

    return n * Factorial(n - 1);
}


Console.WriteLine(Power(2, 4));
Console.WriteLine(Factorial(7));
