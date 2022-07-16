using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMnemonics
{
    public class Solution
    {
        public void GetMnemonics(string str)
        {
            var numChars = new Dictionary<char, string>()
            {
                { '1', ""},
                { '2', "ABC"},
                { '3', "DEF"},
                { '4', "GHI"},
                { '5', "JKL"},
                { '6', "MNO"},
                { '7', "PQRS"},
                { '8', "TUV"},
                { '9', "WXYZ"},
                { '0', ""}
            };

            var result = GetMnemonics(new StringBuilder(str), numChars);
            var count = 0;
            foreach (var r in result)
            {
                System.Console.WriteLine(r);
                count += 1;
            }
            System.Console.WriteLine(count);

        }

        public List<string> GetMnemonics(StringBuilder str, Dictionary<char, string> numChars)
        {
            var result = new List<string>();
            if (str.Length == 1)
            {
                foreach (char c in numChars[str[0]])
                {
                    result.Add(c + "");
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[0];
                var ce = numChars[c];
                str.Remove(0, 1);
                var r = GetMnemonics(str, numChars);
                foreach (var cc in ce)
                {
                    foreach (var s in r)
                    {
                        result.Add(cc + s);
                    }
                }
            }

            return result;
        }

    }
}