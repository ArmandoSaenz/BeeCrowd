using System;


namespace Ejercicio_1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 1;
            for (int i = int.Parse(Console.ReadLine()); i > 1; result *= i--);
            Console.WriteLine(result);

        }
    }
}
