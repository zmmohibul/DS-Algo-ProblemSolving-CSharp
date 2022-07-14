using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercises
    {
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