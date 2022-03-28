// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

Multiply("121", "132");
// System.Console.WriteLine(GetProdOfCharAndString('7', "82346"));

string Multiply(string num1, string num2) {
    List<string> partialProducts = new List<string>();

    for (int i = num2.Length - 1; i >= 0; i--) {
        partialProducts.Add(GetProdOfCharAndString(num2[i], num1));
    }

    foreach (var item in partialProducts) {
        System.Console.WriteLine(item);
    }

    

    return string.Empty;        
}

string GetProdOfCharAndString(char c, string s) {
    StringBuilder sb = new StringBuilder();
    int carry = 0;
    int rem = 0;
    for (int i = s.Length - 1; i >= 0; i--) {
        int prod = (c - '0') * (s[i] - '0') + carry;
        rem = prod % 10;
        carry = prod / 10;
        sb.Insert(0, rem.ToString());
    }

    if (carry > 0) {
        sb.Insert(0, carry.ToString());
    }

    return sb.ToString();
}
