DiStringMatch("IDID").ToList().ForEach(item => Console.Write($"{item}, "));

int[] DiStringMatch(string s) 
{
    int[] perm = new int[s.Length + 1];
    int highestNum = s.Length;
    int lowestNum = 0;
    int i = 0;
    char lastChar = 'I';
    foreach (var c in s)
    {
        if (c.Equals('I'))
        {
            perm[i] = lowestNum;
            lowestNum += 1;
        }
        else if (c.Equals('D'))
        {
            perm[i] = highestNum;
            highestNum -= 1;
        }

        i += 1;
        lastChar = c;
    }

    if (lastChar.Equals('I'))
    {
        perm[i] = lowestNum;
    }
    else
    {
        perm[i] = highestNum;
    }

    return perm;
}