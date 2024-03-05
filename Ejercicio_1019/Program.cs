using System;

namespace Ejercicio_1019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seconds;
            TimeSpan time;
            seconds = int.Parse(Console.ReadLine());
            time = new TimeSpan(0, 0, seconds);
            Console.WriteLine($"{time.Hours + time.Days*24}:{time.Minutes}:{time.Seconds}");
            Console.ReadLine();
        }
    }
}
