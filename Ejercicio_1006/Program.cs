using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, resultado;
            double pa = 2.0 / 10.0, pb = 3.0 / 10.0, pc = 5.0 / 10.0;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            resultado = a * pa + b * pb + c * pc;
            Console.WriteLine("MEDIA = {0}", resultado.ToString("F1"));
        }
    }
}
