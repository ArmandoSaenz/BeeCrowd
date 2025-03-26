using System;

namespace Ejercicio_1170
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] limfood = new int[] {0, 1, 2, 4, 8, 16, 32, 64, 128, 255, 512, 1024 };
            int t = int.Parse(Console.ReadLine());
            double food;
            int day;
            for(int i = 0; i <t; ++i)
            {
                food = double.Parse(Console.ReadLine());
                for (day = 0; food > limfood[day]; ++day);
                --day;
                Console.WriteLine($"{day} dias");
            }
        }
    }
}