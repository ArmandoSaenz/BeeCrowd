using System;

namespace Ejercicio_1306
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string eof = "0 0";
            string line;
            string[] data;
            decimal r, d, n;
            for (int i = 1; (line = Console.ReadLine()) != eof; ++i)
            {
                data = line.Split(' ');
                r = int.Parse(data[0]);
                d = int.Parse(data[1]);
                n = Math.Ceiling(r / d)-1;
                Console.WriteLine($"Case {i}: {(n >= 27 ? "impossible" : n.ToString())}");
            }
        }
    }
}
