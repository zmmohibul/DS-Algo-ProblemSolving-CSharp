using System.Text;

string RestoreString(string s, int[] indices) {
    var sb = new StringBuilder(s);

    for (int i = 0; i < indices.Length; i++)
    {
        sb[indices[i]] = s[i];
    }


    return sb.ToString();
        
}

System.Console.WriteLine(RestoreString("codeleet", new int[]{4,5,6,7,0,2,1,3}));
System.Console.WriteLine(RestoreString("codeeelt", new int[]{4,5,6,7,2,1,0,3}));
