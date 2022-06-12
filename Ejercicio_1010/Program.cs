using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c1, c2;
            float p1, p2, total;
            string datos;
            string[] data;
            //Get data of product 1
            datos = Console.ReadLine();
            data = datos.Split(' ');
            c1 = int.Parse(data[1]);
            p1 = float.Parse(data[2]);
            //Get data of product 2
            datos = Console.ReadLine();
            data = datos.Split(' ');
            c2 = int.Parse(data[1]);
            p2 = float.Parse(data[2]);
            //Compute total
            total = c1 * p1 + c2 * p2;
            Console.WriteLine("VALOR A PAGAR: R$ {0}", total.ToString("F2"));
        }
    }
}
