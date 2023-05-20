using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            string[] values;
            int tea;
            int[] answers;
            int output;
            data = Console.ReadLine();
            tea = int.Parse(data);
            data = Console.ReadLine();
            values = data.Split(' ');
            answers = Array.ConvertAll<string, int>(values, int.Parse);
            output = answers.Count(arg => arg == tea);
            Console.WriteLine(output);
        }
    }
}
