using System.Text;

int MaxSubArraySum(List<int> list, int n)
{
    
    /*
     * [1, 4, 6, 9, 13, 17, 22, 29, 31, 83, 88, 91, 94, 97]
     * 
     */

    var maxSum = 0;
    var tempSum = 0;
    for (int i = 0; i < n; i++)
    {
        tempSum += list[i];
        maxSum += list[i];
    }

    var j = 0;
    for (int i = n; i < list.Count; i++)
    {
        tempSum += list[i];
        tempSum -= list[j];
        if (tempSum > maxSum)
        {
            maxSum = tempSum;
        }
        j += 1;
    }
    
    return maxSum;
}

int FindLongestSubstring(string s) 
{
    //  "longestsubstring"
    //   0123456789012345 
    Dictionary<string, Tuple<int, int>> words = new Dictionary<string, Tuple<int, int>>();

    Dictionary<char, int> charContains = new Dictionary<char, int>();

    int maxLength = 0;
    int i = 0;
    int j = 1;
    while (j < s.Length) {
        charContains[s[i]] = i;
        if (!charContains.ContainsKey(s[j])) {
            charContains[s[j]] = j;
            j += 1;
        } else {
            words[s.Substring(i, j - i)] = new Tuple<int, int>(i, j - 1);
            i = charContains[s[j]] + 1;
            j = i + 1;
            charContains = new Dictionary<char, int>();
            charContains[s[i]] = i;
        }
    }

    words[s.Substring(i)] = new Tuple<int, int>(i, j - 1);

    foreach (var kv in words) {
        int wordLength = kv.Value.Item2 - kv.Value.Item1 + 1;
        if (wordLength > maxLength) {
            maxLength = wordLength;
        }
    }
    

    return maxLength;
}

var l = new List<int>() {1, 4, 6, 9, 13, 88, 91, 94, 95, 17, 22, 29, 31, 83, 88, 91, 94, 96};
Console.WriteLine(MaxSubArraySum(l, 4));
Console.WriteLine(FindLongestSubstring("longestsubstring"));
Console.WriteLine(FindLongestSubstring("thisisawesome"));
Console.WriteLine(FindLongestSubstring("thecatinthehat"));