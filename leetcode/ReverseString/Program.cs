var s = new char[] {'h', 'e', 'l', 'l', 'o'};
ReverseString(s);

foreach(var item in s) {
    System.Console.Write($"{item}, ");
}


void ReverseString(char[] s) {
    int i, j;
    for (i = 0, j = s.Length - 1; i < j; i++, j--) {
        var c = s[j];
        s[j] = s[i];
        s[i] = c;
    }
}