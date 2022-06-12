using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            double volumen;
            double pi = 3.14159;
            r = int.Parse(Console.ReadLine());
            volumen = 4.0 / 3.0 * pi * Math.Pow(r, 3);
            Console.WriteLine("VOLUME = {0}", volumen.ToString("F3"));

        }
    }
}
