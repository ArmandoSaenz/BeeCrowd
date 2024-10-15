using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_1785
{
    internal class Program
    {
        static int[] invalids = new int[] {0, 1111, 2222, 3333, 4444, 5555, 6666, 7777, 8888, 9999 };
        static int krapekar(int X)
        {
            if(invalids.Contains(X))
            { 
                return -1; 
            }
            int cnt = 0;
            int hi, lo;
            while (X != 6174)
            {
                (lo, hi) = Combinacion(X);
                X = hi - lo;
                cnt = cnt + 1;
            }
            return cnt;
        }

        static (int, int) Combinacion(int X)
        {
            var digits = X.ToString().PadLeft(4,'0').Select(digit => int.Parse(digit.ToString())).ToArray();
            return (digits.OrderBy(x => x).Aggregate((acc, d) => acc * 10 + d), digits.OrderByDescending(x => x).Aggregate((acc, d) => acc * 10 + d));
        }

        static void Main(string[] args)
        {
            int tc;
            int num;
            tc = int.Parse(Console.ReadLine());
            for (int i = 1; i <= tc; i++)
            {
                num = int.Parse(Console.ReadLine());
                
                Console.WriteLine($"Case {i}: {krapekar(num)}");
            }    
        }
    }
}