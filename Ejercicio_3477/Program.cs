using System;

namespace Ejercicio_3477
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarando variables
            int x, y, z;
            string line;
            string[] data;
            //Obteniendo los datos
            line = Console.ReadLine();
            data = line.Split(' ');
            x = int.Parse(data[0]);
            y = int.Parse(data[1]);
            z = int.Parse(data[2]);
            //Verificando que los datos sean de un triangulo reactangulo
            if(x*x != y*y+z*z)
            {
                Console.WriteLine("Nao eh retangulo!");
            }
            else
            {
                decimal Area = (z * y) / 2 + 3 * z * z / 8;
                Console.WriteLine($"AREA = {Area}");
            }
        }
    }
}
