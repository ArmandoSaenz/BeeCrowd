using System;

namespace Ejercicio_1161
{
    internal class Program
    {
        static decimal Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            string data;
            int[] values;
            decimal res1, res2;
            while (!String.IsNullOrEmpty(data = Console.ReadLine()))
            {
                values = Array.ConvertAll<string, int>(data.Split(' '), int.Parse);
                res1 = Factorial(values[0]);
                res2 = Factorial(values[1]);
                Console.WriteLine(res1 + res2);
            }
        }
    }
}
