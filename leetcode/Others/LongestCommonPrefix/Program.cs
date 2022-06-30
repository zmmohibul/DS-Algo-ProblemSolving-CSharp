// See https://aka.ms/new-console-template for more information

// System.Console.WriteLine(LongestCommonPrefix(new string[] {"flower", "flow", "flight"}));;

// System.Console.WriteLine(LongestCommonPrefix(new string[] {"flower", "flow", "flood", "floor"}));;

// LongestCommonPrefix(new string[] {"flower", "flow", "flood", "floor"});

// System.Console.WriteLine(LongestCommonPrefix(new string[] {"hover", "hovers", "hovern", "hovert"}));;
// System.Console.WriteLine(LongestCommonPrefix(new string[] {"dog","racecar","car"}));;
System.Console.WriteLine(LongestCommonPrefix(new string[] {"ab", "a"}));;



// ["ab", "a"]
// ["dog","racecar","car"]






string LongestCommonPrefix(string[] strs) {
    int i, j;
    for (i = 0; i < strs[0].Length; i++) {
        char c = strs[0][i];
        for (j = 1; j < strs.Length; j++) {
            if (i >= strs[j].Length) {
                // break;
                return strs[0].Substring(0, i);
            }

            if (!strs[j][i].Equals(c)) {
                return strs[0].Substring(0, i);
            }
        }
    }
    
    return strs[0].Substring(0, i);

}

Console.WriteLine("Hello, World!");
 