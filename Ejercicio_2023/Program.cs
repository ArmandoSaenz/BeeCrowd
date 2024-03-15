using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2023
{
    internal class Program
    {
        static string Truncate(double number, int decimals)
        {
            number *= Math.Pow(10, decimals);
            number = (int)number;
            number /= Math.Pow(10, decimals);
            return number.ToString();
        }
        static void Main(string[] args)
        {
            string endstring = "0";
            string data;
            int tc = 0, city = 0;
            List<string[]> values;
            Dictionary<int, (int, double)> Consume = new Dictionary<int, (int, double)>();
            while((data = Console.ReadLine())!= endstring)
            {
                ++city;
                tc = int.Parse(data);
                values = new List<string[]>();
                for(int i = 0; i < tc; ++i)
                {
                    values.Add(Console.ReadLine().Split(' '));
                }
            }
            
        }
    }
}
