// See https://aka.ms/new-console-template for more information

System.Console.WriteLine(Reverse(1239985));
System.Console.WriteLine(Reverse(-120));
System.Console.WriteLine(Reverse(2147483643));

int Reverse(int x) {
    int result = 0;

    int x1;
    if (x < 0) {
        x1 = -x;
    } else {
        x1 = x;
    }

    while (x1 > 0) {
        if (result > (int.MaxValue / 10)) {
            return 0;
        } else {
            result *= 10;
        }
        int val = x1 % 10;
        if (result > (int.MaxValue - val)) {
            return 0;
        }
        result += val;
        x1 /= 10;
    }

    if (x < 0) {
        return -result;
    } else {
        return result;
    }
        
}
Console.WriteLine("Hello, World!");
