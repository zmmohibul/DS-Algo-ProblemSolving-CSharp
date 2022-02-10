int Power(int baseNum, int exponent)
{
    if (exponent == 0)
    {
        return 1;
    }

    return baseNum * Power(baseNum, exponent - 1);
}

Console.WriteLine(Power(2, 4));
