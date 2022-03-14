using System.Text;


var words = new string[] {"car", "bike", "truck"};
Console.WriteLine("Hello, World!");

Recursion.CapitalizeFirst(words);
foreach (var word in words) 
{
    System.Console.WriteLine(word);
}


class Recursion 
{
    public static void CapitalizeFirst(string[] arr)
    {
        CapitalizeFirst(arr, 0);
    }

    public static void CapitalizeFirst(string[] arr, int n)
    {
        if (n == arr.Length) 
        {
            return;
        }

        var sb = new StringBuilder(arr[n]);
        var s = sb[0].ToString().ToUpper();
        sb[0]= s[0];
        arr[n] = sb.ToString();
        CapitalizeFirst(arr, n + 1);
    }
}

