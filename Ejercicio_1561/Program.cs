using System;
using System.Linq;

namespace Ejercicio_1561
{
    internal class Program
    {
        static (int,int) ConvertTime2Int(string time)
        {
            var data = time.Split(':');
            return (int.Parse(data[0]), int.Parse(data[1]));
        }
        static char[] Clock = ($" ____________________________________________\n" +
                        $"|                                            |\n" +
                        $"|    ____________________________________    |_\n" +
                        $"|   |                                    |   |_)\n" +
                        $"|   |   8         4         2         1  |   |\n" +
                        $"|   |                                    |   |\n" +
                        $"|   |   D         C         B         A  |   |\n" +
                        $"|   |                                    |   |\n" +
                        $"|   |                                    |   |\n" +
                        $"|   |   J     I     H     G     F     E  |   |\n" +
                        $"|   |                                    |   |\n" +
                        $"|   |   32    16    8     4     2     1  |   |_\n" +
                        $"|   |____________________________________|   |_)\n" +
                        $"|                                            |\n" +
                        $"|____________________________________________|\n").ToCharArray();

        const char bit = 'o';
        const char empty = ' ';
        static void Main(string[] args)
        {
            string[] binaries = new string[10]; 
            string line;
            int h, m;
            //bool first = true;
            //Console.WriteLine(Clock.ToList().IndexOf('A'));
            //Console.WriteLine(Clock.ToList().IndexOf('B'));
            //Console.WriteLine(Clock.ToList().IndexOf('C'));
            //Console.WriteLine(Clock.ToList().IndexOf('D'));
            //Console.WriteLine(Clock.ToList().IndexOf('E'));
            //Console.WriteLine(Clock.ToList().IndexOf('F'));
            //Console.WriteLine(Clock.ToList().IndexOf('G'));
            //Console.WriteLine(Clock.ToList().IndexOf('H'));
            //Console.WriteLine(Clock.ToList().IndexOf('I'));
            //Console.WriteLine(Clock.ToList().IndexOf('J'));
            //Console.WriteLine();
            while (!String.IsNullOrEmpty(line = Console.ReadLine()))
            {
                (h,m) = ConvertTime2Int(line);
                Clock[322] = (h & 1) == 1 ? bit : empty;
                Clock[312] = (h & 2) == 2 ? bit : empty;
                Clock[302] = (h & 4) == 4 ? bit : empty;
                Clock[292] = (h & 8) == 8 ? bit : empty;
                Clock[463] = (m & 1) == 1 ? bit : empty;
                Clock[457] = (m & 2) == 2 ? bit : empty;
                Clock[451] = (m & 4) == 4 ? bit : empty;
                Clock[445] = (m & 8) == 8 ? bit : empty;
                Clock[439] = (m & 16) == 16 ? bit : empty;
                Clock[433] = (m & 32) == 32 ? bit : empty;
                Console.WriteLine(Clock);
            }
        }
    }
}