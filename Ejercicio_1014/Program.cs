using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float z = x / y;
            Console.WriteLine($"{z.ToString("F3")} km/l");
        }
    }
}
