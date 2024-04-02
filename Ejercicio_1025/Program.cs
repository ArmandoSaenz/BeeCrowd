using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            string[] datos;
            List<int> Canicas = new List<int>();
            List<int> Preguntas = new List<int>();
            string end = "0 0";
            int n, q;
            for(int i = 1; (data = Console.ReadLine())!= end; ++i)
            {
                datos = data.Split(' ');
                n = int.Parse(datos[0]);
                q = int.Parse(datos[1]);
                for(int j = 0; j < n; ++j)
                    Canicas.Add(int.Parse(Console.ReadLine()));
                for (int j = 0; j < q; ++j)
                    Preguntas.Add(int.Parse(Console.ReadLine()));
                Canicas.Sort();
                Console.WriteLine($"CASE# {i}:");
                Preguntas.ForEach(x => Console.WriteLine((Canicas.Contains(x) ? $"{x} found at {Canicas.IndexOf(x) + 1}" : $"{x} nor found")));
            }
        }
    }
}
