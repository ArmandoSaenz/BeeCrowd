using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1878
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            string[] data;
            int N, M;
            int[] ci;
            while (String.IsNullOrEmpty(line = Console.ReadLine()))
            {
                data = line.Split(' ');
                N = int.Parse(data[0]);
                M = int.Parse(data[1]);
                data = Console.ReadLine().Split(' ');
                ci = Array.ConvertAll(data, int.Parse);
                switch(N)
                {
                    case 1:
                        Console.WriteLine("Lucky Denis!");
                        break;
                    case 2:
                        if (ci[0] * (M - 1) < ci[1])
                            Console.WriteLine("Lucky Denis!");
                        else
                            Console.WriteLine("Try again later, Denis...");
                        break;
                    case 3:

                }
            }
        }
    }
}
