using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Ejercicio_1033
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            string[] data;
            int n, b;
            string endline = "0 0";
            double n0 = 0, n1=1, n2=1, idx = 0;
            while (true)
            {
                n0 = n1 + n2 + 1;
                Console.WriteLine($"{++idx}-{n0},{n1},{n2}");
                n2 = n1;
                n1 = n0;
                Console.ReadLine();
            }

            /*
            while((line = Console.ReadLine()) != endline)
            {
                data = line.Split(' ');
                n = int.Parse(data[0]);
                b = int.Parse(data[1]);
                
            }*/
            Console.ReadLine();
        }
    }
}
