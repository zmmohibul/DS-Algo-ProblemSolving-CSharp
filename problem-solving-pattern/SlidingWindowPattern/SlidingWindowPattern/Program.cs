﻿using System.Text;

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

string FindLongestSubstring(string s) 
{
    //  "longestsubstring"
    //   0123456789012345 
    StringBuilder sb = new StringBuilder();
    int maxLength = 0;
    Dictionary<char, int> containsChar = new Dictionary<char, int>();
    Dictionary<string, int> longestWords = new Dictionary<string, int>();

    int i, j;
    for (i = 0, j = 1; j < s.Length; j++) {
        containsChar[s[i]] = i;
        if (containsChar.ContainsKey(s[j])) {
            sb.Insert(0, s[i]);
            i = containsChar[s[j]] + 1;
            containsChar = new Dictionary<char, int>();
            containsChar[s[j]] = j;
            containsChar[s[i]] = i;
            longestWords[sb.ToString()] = sb.Length;
            sb = new StringBuilder();
            sb.Append(s[j]);
        } 
        else {
            sb.Append(s[j]);
            containsChar[s[j]] = j;
        }
    }

    sb.Append(s.Substring(i, j - i));
    Console.WriteLine(j - i);
    foreach (var kv in containsChar) {
        Console.WriteLine(kv.Key);
    }

    return sb.ToString();
}

var l = new List<int>() {1, 4, 6, 9, 13, 88, 91, 94, 95, 17, 22, 29, 31, 83, 88, 91, 94, 96};
Console.WriteLine(MaxSubArraySum(l, 4));
Console.WriteLine(FindLongestSubstring("longestsubstring"));