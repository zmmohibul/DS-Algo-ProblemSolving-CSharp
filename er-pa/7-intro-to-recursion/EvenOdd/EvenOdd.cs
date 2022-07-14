using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvenOdd
{
    public class EvenOdd
    {
        public bool IsEven(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("BAD INPUT!!!");
            }
            
            if (n == 0)
            {
                return true;
            }
            else
            {
                return IsOdd(n - 1);
            }
        }

        public bool IsOdd(int n)
        {
            return !IsEven(n);
        }
    }
}