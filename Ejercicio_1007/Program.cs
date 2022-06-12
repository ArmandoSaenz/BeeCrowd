using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            int resultado;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());
            resultado = a * b - c * d;
            Console.WriteLine("DIFERENCA = {0}", resultado);
        }
    }
}
