var s = "wednesdayint";

var substringIndexDict = new Dictionary<int, Tuple<int, int>>();
var containsDict = new Dictionary<char, int>();

int i, j;
int maxLength = 0;
bool ifirst = true;
int length = 0;
for (i = 0, j = 0; j < s.Length; j++) {
    if (!containsDict.ContainsKey(s[j])) {
        containsDict[s[j]] = j;
    }  else if (containsDict[s[j]] > i && !ifirst) {
        containsDict[s[j]] = j;
    } else {
        length = j - i;
        substringIndexDict[length] = new Tuple<int, int>(i, j - 1);
        if (length > maxLength) {
            maxLength = length;
        }
        i = containsDict[s[j]] + 1;
        containsDict[s[j]] = j;
        ifirst = false;
    }

}


length = j - i;
substringIndexDict[length] = new Tuple<int, int>(i, j - 1);
if (length > maxLength) {
    maxLength = length;
}

foreach (var (key, val) in substringIndexDict) {
    System.Console.WriteLine($"{key} : {val}");
}

var t = substringIndexDict[maxLength];
System.Console.WriteLine(t);
System.Console.WriteLine(s.Substring(t.Item1, t.Item2 - t.Item1 + 1));
