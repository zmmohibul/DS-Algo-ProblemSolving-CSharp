DiStringMatch("IDID").ToList().ForEach(item => Console.Write($"{item}, "));

int[] DiStringMatch(string s) 
{
    int[] prem = new int[s.Length + 1];

    int highestNum = s.Length;
    int lowestNum = 0;
    char lastChar = s[0];

    int i = 0;

    for (i = 1; i <= s.Length + 1; i++)
    {
        if (lastChar == 'I')
        {
            prem[i-1] = lowestNum;
            lowestNum += 1;
        }
        else 
        {
            prem[i-1] = highestNum;
            highestNum -= 1;
        }

        if (i < s.Length)
        {
            lastChar = s[i];
        }
    }

    return prem;
}