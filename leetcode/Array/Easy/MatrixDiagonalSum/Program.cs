using System;

namespace MatrixDiagonalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var mat = new int[3][];
            int n = 1;
            for (int i = 0; i < 3; i++)
            {
                var row = new int[3];
                for (int j = 0; j < 3; j++)
                {
                    row[j] = n;
                    n += 1;
                }

                mat[i] = row;
            }

            foreach (var row in mat)
            {
                foreach (var num in row)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            
            Solution sl = new Solution();
            Console.WriteLine(sl.DiagonalSum(mat));
        }
    }
}
