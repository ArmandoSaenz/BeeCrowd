using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_2034
{
    internal class Program
    {
        static double Card(int n, List<char> elements, string number)
        {
            int can = number.Length;
            double pos = 0;
            for (int j = 1; j <= can; ++j)
                pos += Math.Pow(n, n - j) * elements.IndexOf(number[j-1]);
            return pos;
        }
        static string ConverToBase(int b, double number)
        {
            string convert = "";
            while(number / b > 0)
            {
                convert = convert.Insert(0, (number % b).ToString());
                number = Math.Floor(number / b);
            }
            return convert;
        }
        static void Main(string[] args)
        {
            double D, H;
            int B;
            string C;
            List<char> digits = new List<char> { '0','2','3'};
            const string end = "-1 -1 -1 *";
            string data;
            string[] values;
            double CanNumbers;
            int numbits = 1;
            Console.WriteLine(ConverToBase(3, 363));
            while((data = Console.ReadLine())!= end)
            {
                values = data.Split(' ');
                D = long.Parse(values[0]);
                H = long.Parse(values[1]);
                B = int.Parse(values[2]);
                C = values[3];
                digits = new List<char>();
                CanNumbers = H - D + 1;
                for (int i = 0; i < B; ++i)
                    if (C[i] == 'S') digits.Add((char)(i+48));
                if (C.Count(item => item == 'S') == C.Length)
                    Console.WriteLine(CanNumbers);
                else if (C.Count(item => item == 'S') == 1 && C[0] == 'S')
                    Console.WriteLine("0");
                for (numbits = 1; Math.Pow(B, numbits) < H; ++numbits) ;
                Console.WriteLine(ConverToBase(B, H));

            }
        }
    }
}
