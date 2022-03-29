// See https://aka.ms/new-console-template for more information

System.Console.WriteLine(LongestCommonPrefix(new string[] {"flower", "flow", "flight"}));;

System.Console.WriteLine(LongestCommonPrefix(new string[] {"flower", "flow", "flood", "floor"}));;

// LongestCommonPrefix(new string[] {"flower", "flow", "flood", "floor"});

System.Console.WriteLine(LongestCommonPrefix(new string[] {"hover", "hovers", "hovern", "hovert"}));;






string LongestCommonPrefix(string[] strs) {
    int a = 0;
    int b = 0;
    var dict = new Dictionary<Tuple<int, int>, int>();  

    int maxSubStringLength = 0;
    for (int i = 0; i < strs[0].Length; i++) {
        bool allEqual = true;
        char c = strs[0][i];
        for (int j = 1; j < strs.Length; j++) {
            if (i >= strs[j].Length) {
                break;
            }
            if (!strs[j][i].Equals(c)) {
                allEqual = false;
                break;
            }
        }

        if (allEqual) {
            maxSubStringLength += 1;
            b = i;
            System.Console.WriteLine(strs[0].Substring(0, b));
        } else {
            dict[new Tuple<int, int>(a, b)] = maxSubStringLength;
            a = b;
            b = i;
            maxSubStringLength = 0;
        }
    }

    if (a == 0 && !dict.ContainsKey(new Tuple<int, int>(a, b))) {
        dict[new Tuple<int, int>(a, b)] = maxSubStringLength;
    }

    foreach (var (key, val) in dict) {
        System.Console.WriteLine($"{key} : {val}");
    }

    return strs[0].Substring(a, maxSubStringLength);

}

Console.WriteLine("Hello, World!");
 