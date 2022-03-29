// See https://aka.ms/new-console-template for more information

System.Console.WriteLine(Reverse(1239985));

System.Console.WriteLine(Reverse(121));

bool Reverse(int x) {
    int result = 0;
    int ox = x;
    while (x > 0) {
        int val = x % 10;
        result += val;
        x /= 10;
        if (x > 0) {
            result *= 10;
        }
    }

    System.Console.WriteLine(result);

    if (ox == result) {
        return true;
    } else {
        return false;
    }        
}
Console.WriteLine("Hello, World!");
