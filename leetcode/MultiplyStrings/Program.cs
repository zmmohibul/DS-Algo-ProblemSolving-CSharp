// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

// Multiply("121", "132");
System.Console.WriteLine(GetProdOfCharAndString('7', "82346"));

string Multiply(string num1, string num2) {

    int maxLength = num1.Length > num2.Length ? num1.Length : num2.Length;
    int i, j;
    int num1Length = num1.Length;
    int num2Length = num2.Length;

    int carry = 0;
    int rem = 0;
    StringBuilder sb = new StringBuilder();
    for (i = num1Length - 1, j = num2Length - 1; i >= 0 && j >= 0; i--, j--) {
        int product = (num1[i] - '0') * (num2[j] - '0')  + carry;
        rem = product % 10;
        carry = product / 10;
        sb.Insert(0, rem.ToString());
    }

    System.Console.WriteLine(sb.ToString());

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
