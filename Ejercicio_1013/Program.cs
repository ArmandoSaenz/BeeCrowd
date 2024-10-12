using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1013
{
    class Program
    {
        static int MaiorAB(int A, int B)  => (A + B + Math.Abs(A - B)) / 2;
        static void Main(string[] args)
        {
            //Se lee la linea
            string data = Console.ReadLine();
            string[] numeros = data.Split(' ');
            int[] valores = Array.ConvertAll<string, int>(numeros, int.Parse);
            List<int> values = valores.ToList();
            //Se imprime el resultado
            Console.WriteLine($"{values.Max()} eh o maior");
            Console.ReadLine();
        }
    }
}

