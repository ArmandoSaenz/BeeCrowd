using System;

namespace Ejercicio_1930
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sockets = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);
            Console.WriteLine($"{sockets[0] + sockets[1] + sockets[2] + sockets[3] - 3}");
        }
    }
}
