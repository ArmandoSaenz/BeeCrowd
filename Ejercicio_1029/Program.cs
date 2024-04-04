using System;

namespace Ejercicio_1029
{
    internal class Program
    {
        static int Calls(int n) => n <= 1 ? n : Calls(n - 1) + Calls(n - 2);
        static int Fib(int n) => n <= 1 ? 0 : Fib(n - 1) + Fib(n - 2) + 2;
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; ++i)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"fib(n) = {Fib(n)} calls = {Calls(n)}");
            }
        }
    }
}
