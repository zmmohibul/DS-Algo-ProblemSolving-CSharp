using System.Text;
string[] strArr = {"AB", "BC", "CD", "DE", "EF", "FG", "GH", "IJ" };
string str = string.Join("", strArr);
System.Console.WriteLine(str);


bool ArrayStringsAreEqual(string[] word1, string[] word2) 
{
    var word1Sb = new StringBuilder(string.Join("", word1));
    var word2Sb = new StringBuilder(string.Join("", word2));

    if (word1Sb.Equals(word1Sb))
    {
        return true;
    }
    else 
    {
        return false;
    }
}