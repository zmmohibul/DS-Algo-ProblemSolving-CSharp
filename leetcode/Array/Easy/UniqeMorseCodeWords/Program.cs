using System.Text;

System.Console.WriteLine(UniqueMorseRepresentations(new string[] {"gin","zen","gig","msg"}));;


int UniqueMorseRepresentations(string[] words) 
{
    var uniqueWords = new Dictionary<string, int>();

    var morseCodeList = new List<string> {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};

    var morseCodeAlphabetMap = new Dictionary<char, string>();
    var c = 'a';
    foreach (var code in morseCodeList)
    {
        morseCodeAlphabetMap[c] = code;
        c++;
    }

    foreach (var word in words)
    {
        var sb = new StringBuilder();
        foreach (var wc in word)
        {
            sb.Append(morseCodeAlphabetMap[wc]);
        }

        if (!uniqueWords.ContainsKey(sb.ToString()))
        {
            uniqueWords[sb.ToString()] = 1;
        }
        else
        {
            uniqueWords[sb.ToString()] += 1;
        }
    }

    return uniqueWords.Count;
}