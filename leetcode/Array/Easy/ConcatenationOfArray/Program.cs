using System;
using System.Linq;

int[] GetConcatenation(int[] arr) 
{
    var ans = new int[arr.Length * 2];
    var n = arr.Length;

    for(int i = 0; i < arr.Length; i++)
    {
        ans[i] = arr[i];
        ans[i + n] = arr[i];
    }

    return ans;
}


var nums = new int[] {1,3,2,1};
var result = GetConcatenation(nums);

result.ToList().ForEach(item => Console.Write($"{item}, "));
