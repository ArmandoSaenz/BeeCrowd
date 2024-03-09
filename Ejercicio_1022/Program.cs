using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_1022
{
    public class Program
    {
        static int mcd(int num, int den)
        {
            int a = Math.Abs(num);
            int b = Math.Abs(den);
            while (b != 0)
            {
                int c = a % b;
                a = b;
                b = c;
            }
            return a;
        }
        static (int, int) Simplify(int num, int den)
        {
            int dividir = mcd(num, den);
            num /= dividir;
            den /= dividir;
            return (num, den);
        }
        static (int, int) Sum(int n1, int d1, int n2, int d2) => ((n1 * d2 + n2 * d1), (d1 * d2));
        static (int, int) Rest(int n1, int d1, int n2, int d2) => ((n1 * d2 - n2 * d1), (d1 * d2));
        static (int, int) Product(int n1, int d1, int n2, int d2) => ((n1 * n2), (d1 * d2));
        static (int, int) Divide(int n1, int d1, int n2, int d2) => ((n1 * d2), (d1 * n2));
        static void Main(string[] args)
        {
            int totalcases = int.Parse(Console.ReadLine());
            string data;
            int[] values;
            int num=0, den=0;
            char[] symbols = { '+', '-', '*', '/', ' '};
            string[] numbers;
            for(int i = 0; i < totalcases; ++i)
            {
                data = Console.ReadLine();
                numbers = data.Split(symbols).ToList().FindAll(value => value != "").ToArray();
                values = Array.ConvertAll<string, int>(numbers, int.Parse);
                if(data.Contains("+"))
                {
                    (num, den) = Sum(values[0], values[1], values[2], values[3]);
                    Console.Write($"{num}/{den} = ");
                }
                else if(data.Contains("-"))
                {
                    (num, den) = Rest(values[0], values[1], values[2], values[3]);
                    Console.Write($"{num}/{den} = ");
                }
                else if (data.Contains("*"))
                {
                    (num, den) = Product(values[0], values[1], values[2], values[3]);
                    Console.Write($"{num}/{den} = ");
                }
                else
                {
                    (num, den) = Divide(values[0], values[1], values[2], values[3]);
                    Console.Write($"{num}/{den} = ");
                }
                (num, den) = Simplify(num, den);
                Console.WriteLine($"{num}/{den}");
            }
        }
    }
}
