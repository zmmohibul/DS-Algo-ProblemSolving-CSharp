using System;
using System.Linq;

int[] RunningSum(int[] arr)
{
    var result = new int[arr.Length];
    var sum = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
        result[i] = sum;
    }


    return result;
}

var result = RunningSum(new int[] {1, 2, 3, 4});
result.ToList().ForEach(item => Console.Write($"{item}, "));