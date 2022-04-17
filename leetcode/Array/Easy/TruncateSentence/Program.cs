using System.Text;

string TruncateSentence(string s, int k) 
{
    var sb = new StringBuilder();

    var count = 0;
    var i = 0;
    while (i < s.Length)
    {
        if (s[i].Equals(' '))
        {
            count += 1;
        }
        if (count == k)
        {
            break;
        }
        sb.Append(s[i]);
        i += 1;
    }

    return sb.ToString();
        
}