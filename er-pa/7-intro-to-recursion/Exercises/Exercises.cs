using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercises
    {
        public string StringReverse(string str)
        {
            var sb = new StringBuilder(str);
            return StringReverse(sb, 0, sb.Length - 1);
        }

        public string StringReverse(StringBuilder sb, int p1, int p2)
        {
            if (p1 >= p2)
            {
                return sb.ToString();
            }

            var c = sb[p1];
            sb[p1] = sb[p2];
            sb[p2] = c;
            return StringReverse(sb, p1 + 1, p2 - 1);
        }
        public int DigitalRoot(int n)
        {
            if (n / 10 == 0)
            {
                return n;
            }
            else
            {
                return DigitalRoot(DigitSum(n));
            }
        }
        public int DigitSum(int n)
        {
            if (n / 10 == 0)
            {
                return n;
            }
            else
            {
                return (n % 10) + DigitSum(n / 10);
            }
        }
    }
}