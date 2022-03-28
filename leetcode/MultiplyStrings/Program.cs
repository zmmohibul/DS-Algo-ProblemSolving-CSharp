// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");

Multiply("247", "319");
// System.Console.WriteLine(GetProdOfCharAndString('7', "82346"));

string Multiply(string num1, string num2) {
    List<string> partialProducts = new List<string>();
    int maxPartialProductLength = 0;
    int extraZeroes = 0;

    for (int i = num2.Length - 1; i >= 0; i--) {
        var partialProduct = GetProdOfCharAndString(num2[i], num1, extraZeroes);
        partialProducts.Add(partialProduct);
        extraZeroes += 1;
        if (partialProduct.Length > maxPartialProductLength) {
            maxPartialProductLength = partialProduct.Length;
        }
    }

    StringBuilder sb = new StringBuilder();

    var sum = 0;
    var rem = 0;
    var carry = 0; 

    for (int i = 0; i < maxPartialProductLength; i++) {

        foreach (var product in partialProducts) {
            if (i < product.Length) {
                sum += product[i] - '0';
            }
        }

        sum += carry;
        rem = sum % 10;
        carry = sum / 10;

        sum = 0;

        sb.Insert(0, rem);
    }

    if (carry > 0) {
        sb.Insert(0, carry);
    }

    foreach (var item in partialProducts) {
        System.Console.WriteLine(item);
    }

    System.Console.WriteLine(sb.ToString());



    return string.Empty;        
}

string GetProdOfCharAndString(char c, string s, int extraZeroToAdd) {
    StringBuilder sb = new StringBuilder();
    int carry = 0;
    int rem = 0;
    for (int i = s.Length - 1; i >= 0; i--) {
        int prod = (c - '0') * (s[i] - '0') + carry;
        rem = prod % 10;
        carry = prod / 10;
        // sb.Insert(0, rem.ToString());
        sb.Append(rem);
    }

    if (carry > 0) {
        // sb.Insert(0, carry.ToString());
        sb.Append(carry);
    }

    for (int i = 0; i < extraZeroToAdd; i++) {
        sb.Insert(0, 0);
    }

    return sb.ToString();
}
