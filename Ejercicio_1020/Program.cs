using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1020
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> Period = new Dictionary<string, int>() { {"ano(s)", 365},{"mes(es)", 30},{"dia(s)", 1} };
            int days = int.Parse(Console.ReadLine());
            foreach(KeyValuePair<string, int> item in Period)
            {
                Console.WriteLine($"{days / item.Value} {item.Key}");
                days = days % item.Value;
            }
            Console.ReadLine();
        }
    }
}
