using System;

namespace Ejercicio_1028
{
    internal class Program
    {
        static int MCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; ++i)
            {
                string data = Console.ReadLine();
                string[] values = data.Split(' ');
                int a = int.Parse(values[0]);
                int b = int.Parse(values[1]);
                int c = MCD(a, b);
                Console.WriteLine(c);
            }
        }
    }
}
