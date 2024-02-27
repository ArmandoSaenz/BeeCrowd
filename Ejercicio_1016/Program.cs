using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se lee la velocidad
            int distance = int.Parse(Console.ReadLine());
            //Se calcula el tiempo con una constante de 2 min/km
            int time = distance * 2;
            //Se imprime resultado
            Console.WriteLine($"{time} minutos");
        }
    }
}
