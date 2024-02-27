using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1013
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se lee la linea
            string data = Console.ReadLine();
            //Se convierten los tres numeros a entero
            List<int> values = Array.ConvertAll<string, int>(data.Split(' '), int.Parse).ToList();
            //Se imprime el resultado
            Console.WriteLine($"{values.Max()} eh o maior");
        }
    }
}

