using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1093
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string eof = "0 0 0 0";
            double v1, v2, atk, d, loss, win;
            double probability;
            string line;
            string[] data;
            while ((line = Console.ReadLine()) != eof)
            {
                data = line.Split(' ');
                v1 = double.Parse(data[0]);
                v2 = double.Parse(data[1]);
                atk = double.Parse(data[2]);
                d = double.Parse(data[3]);
                win = Math.Ceiling(v2 / atk);
                loss = Math.Floor(v1 / atk);
                probability = Math.Pow(atk, win) / Math.Pow(6, win);
                for(int i = 1; i <= loss; ++i)
                {
                    probability += Math.Pow(atk, win + i) / Math.Pow(6, win + i) * Math.Pow(6 - atk, i)/ Math.Pow(6, i);
                }
                Console.WriteLine((probability*100).ToString("F1"));
            }
        }
    }
}
