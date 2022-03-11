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
    Dictionary<char, int> containsChar = new Dictionary<char, int>();

    int maxLength = 0;
    int currentStringLength = 1;
    int i = 0;
    int j = 1;
    int prevJ = 1;
    containsChar[s[i]] = i;
    while (j < s.Length) {
        containsChar[s[i]] = i;
        if(!containsChar.ContainsKey(s[j])) {
            containsChar[s[j]] = j;
            currentStringLength += 1;
            j += 1;
        } else {
            if (currentStringLength > maxLength) {
                maxLength = currentStringLength;
            }
            i = j - 1;
            currentStringLength = 1;
            containsChar = new Dictionary<char, int>();
        }
    }

    // try removing from dictionary

    return maxLength;
}

var l = new List<int>() {1, 4, 6, 9, 13, 88, 91, 94, 95, 17, 22, 29, 31, 83, 88, 91, 94, 96};
Console.WriteLine(MaxSubArraySum(l, 4));
Console.WriteLine(FindLongestSubstring("longestsubstring"));