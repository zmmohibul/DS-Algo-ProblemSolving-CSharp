

Console.WriteLine(Recursion.Power(2, 4));
Console.WriteLine(Recursion.Factorial(7));

var l = new List<int>() {1, 2, 3, 4, 5};
// Console.WriteLine(l[^1]);
// Console.WriteLine(l);
// l.RemoveAt(l.Count - 1);
// l.ForEach(Console.Write);

Console.WriteLine(Recursion.SumOfArray(l));
Console.WriteLine(Recursion.ProductOfList(l));

class Recursion
{
    public static int ProductOfList(List<int> numbers)
    {
        if (numbers.Count == 0)
        {
            return 1;
        }

        var lastValue = numbers[^1];
        numbers.RemoveAt(numbers.Count - 1);
        
        return lastValue * ProductOfList(numbers);
    }

    public static int SumOfArray(List<int> numbers)
    {
        return SumOfArray(numbers, 0);
    }

    public static int SumOfArray(List<int> numbers, int i)
    {
        if (i == numbers.Count)
        {
            return 0;
        }

        return numbers[i] + SumOfArray(numbers, i += 1);
    }
    public static int Power(int baseNum, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }

        return baseNum * Power(baseNum, exponent - 1);
    }

    public static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }

        return n * Factorial(n - 1);
    }
}


