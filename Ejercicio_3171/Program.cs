using System;
using System.Collections.Generic;
using System.Linq;


namespace Ejercicio_3171
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] data;
            int[] numbers = new int[100];
            int L, N;
            for (string line; !String.IsNullOrEmpty(line = Console.ReadLine());)
            {
                data = line.Split(' ');
                L = int.Parse(data[0]);
                N = int.Parse(data[1]);
                ++numbers[L];
                ++numbers[N];
            }
            if(numbers.ToList().TrueForAll(item => item == 2 || item == 0))
            {
                Console.WriteLine("COMPLETO");
            }
            else
            {
                Console.WriteLine("INCOMPLETO");
            }
            Console.ReadLine();
        }
    }
}
