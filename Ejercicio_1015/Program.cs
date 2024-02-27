using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            double[] v1, v2;
            data = Console.ReadLine();
            v1 = Array.ConvertAll<string, double>(data.Split(' '), double.Parse);
            data = Console.ReadLine();
            v2 = Array.ConvertAll<string, double>(data.Split(' '), double.Parse);
            double output = Math.Sqrt(Math.Pow(v1[0] - v2[0], 2) + Math.Pow(v1[1] - v2[1], 2));
            Console.WriteLine(output.ToString("F4"));
        }
    }
}
