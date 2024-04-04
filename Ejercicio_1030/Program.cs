using System;
using System.Collections.Generic;
using System.Linq;


namespace Ejercicio_1030
{
    internal class Program
    {
        static void Kill(List<int> personas, int i, int inc)
        {
            
            if (personas.Count() == 1)
                return;
            else
            {
                personas.RemoveAt(i);
                --i;
                int plive = personas.Count();
                Kill(personas, (i + inc) % plive, inc);
            }
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; ++i)
            {
                string data = Console.ReadLine();
                string[] values = data.Split(' ');
                int a = int.Parse(values[0]);
                int b = int.Parse(values[1]);
                List<int> personas = Enumerable.Range(1, a).ToList();
                try
                {
                    Kill(personas, (b - 1)%a, b);
                    Console.WriteLine($"Case {i + 1}: {personas[0]}");
                }
                catch
                {
                    Console.WriteLine($"Case {a}: {b}");
                }
            }
            Console.ReadLine();
        }
    }
}
