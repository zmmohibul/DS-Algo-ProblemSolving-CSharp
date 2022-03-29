// See https://aka.ms/new-console-template for more information

// var s = "hellother";
var s = "wednesday";

var substringIndexDict = new Dictionary<Tuple<int, int>, int>();
var containsDict = new Dictionary<char, int>();

int i, j;
int maxLength = 0;
bool ifirst = true;
for (i = 0, j = 0; j < s.Length; j++) {
    if (!containsDict.ContainsKey(s[j])) {
        containsDict[s[j]] = j;
    }  else if (containsDict[s[j]] > i && !ifirst) {
        containsDict[s[j]] = j;
    } else {
        int length = j - i;
        substringIndexDict[new Tuple<int, int>(i, j - 1)] = length;
        if (length > maxLength) {
            maxLength = length;
        }
        i += containsDict[s[j]] + 1;
        containsDict[s[j]] = j;
        maxLength = 0;
        ifirst = false;
    }

}



foreach (var (key, val) in substringIndexDict) {
    System.Console.WriteLine($"{key} : {val}");
}
Console.WriteLine("Hello, World!");
