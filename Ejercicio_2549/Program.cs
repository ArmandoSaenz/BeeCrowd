using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2549
{
    internal class Program
    {
        static string Initials(string name)
        {
            string[] names = name.Split(' ');
            return string.Concat(Array.ConvertAll<string, string>(names, arg => arg.Length > 0?arg[0].ToString() : ""));
        }
        static void Main(string[] args)
        {
            List<string> names;
            int total;
            string data;
            while (true)
            {
                if (String.IsNullOrEmpty(data = Console.ReadLine()))
                {
                    break;
                }
                total = int.Parse(data.Split(' ')[0]);
                names = new List<string>();
                for(int i = 0; i < total; ++i)
                {
                    names.Add(Console.ReadLine().Trim());
                }
                Console.WriteLine(total - Array.ConvertAll<string, string>(names.ToArray(), item => Initials(item)).Distinct().Count());
            }
            Console.ReadLine();
        }
    }
}
