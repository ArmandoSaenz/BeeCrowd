using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tiempo en horas
            double time = double.Parse(Console.ReadLine());
            //Velocidad
            double vel = double.Parse(Console.ReadLine());
            //Gasto de gasolita con una relación de 12 km / l
            double gasoline = (time * vel) / 12;
            //Impresión de resultado
            Console.WriteLine(gasoline.ToString("F3"));
        }
    }
}
