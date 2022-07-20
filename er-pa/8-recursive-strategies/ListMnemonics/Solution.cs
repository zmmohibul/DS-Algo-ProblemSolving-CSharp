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
            if (str.Length == 0)
            {
                result.Add("");
            }
            else
            {
                var charsFromNum =  numChars[str[0]];
                str.Remove(0, 1);
                var mnemonicsOfRest = GetMnemonics(str, numChars);
                foreach(var ch in charsFromNum)
                {
                    foreach(var mn in mnemonicsOfRest)
                    {
                        result.Add(ch + mn);
                    }
                }
            }

            return result;
        }

    }
}