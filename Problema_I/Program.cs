using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Problema_I
{
    internal class Program
    {
        static int Kappa(int i, int j, int n)
        {
            if (i == 0)
            {
                
                return (j + 1) % n;
            }
            else if (j == 0)
            {
                fun[i] += 1;
                return Kappa(i - 1, 1, n);
            }
            else
            {
                return Kappa(i - 1, Kappa(i, j - 1, n), n);
            }
        }

        static int[] fun;
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            int i, j, n;
            for (int t = 0; t < tc; ++t)
            {
                string line = Console.ReadLine();
                string[] data = line.Split(' ');
                i = int.Parse(data[0]);
                j = int.Parse(data[1]);
                n = int.Parse(data[2]);
                fun = new int[i+1];
               Console.WriteLine(Kappa(i, j, n));
                printM(fun);
            }
        }
        static void printM(int[] matrix)
        {
            int n = matrix.GetLength(0);
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine($"[{i}-{matrix[i]}]");
            }

        }
    }
}
