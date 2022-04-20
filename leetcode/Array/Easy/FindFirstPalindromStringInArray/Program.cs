System.Console.WriteLine(FirstPalindrome(new string[]{"abc","car","ada","racecar","cool"}));


string FirstPalindrome(string[] words) 
{
    foreach (var word in words)
    {
        if (isPalindrome(word))
        {
            return word;
        }
    }
    return "";
}

bool isPalindrome(string str)
{
    for (int i = 0, j = str.Length - 1; i < j; i++, j--)
    {
        if (!str[i].Equals(str[j]))
        {
            return false;
        }
    }

    return true;
}