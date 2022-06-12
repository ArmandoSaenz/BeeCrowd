using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            double salario, totalVendido;
            double sueldo;
            nombre = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            totalVendido = double.Parse(Console.ReadLine());
            sueldo = salario + 0.15 * totalVendido;
            Console.WriteLine("TOTAL = R$ {0}", sueldo.ToString("F2"));
        }
    }
}
