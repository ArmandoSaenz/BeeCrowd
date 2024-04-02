using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
            int[] Canicas;
            int[] Preguntas;
            int cantidad;
            string end = "0 0";
            int n, q;
            for (int i = 1; (data = Console.ReadLine()) != end; ++i)
            {
                datos = data.Split(' ');
                n = int.Parse(datos[0]);
                q = int.Parse(datos[1]);
                Canicas = new int[10001];
                Preguntas = new int[q];
                for (int j = 0; j < n; ++j)
                    ++Canicas[int.Parse(Console.ReadLine())];
                for (int j = 0; j < q; ++j)
                    Preguntas[j] = int.Parse(Console.ReadLine());
                Console.WriteLine($"CASE# {i}:");
                cantidad = 1;
                var dictionary = Canicas.Select((value, index) => new { index, value }).ToDictionary(item => item.index, item => (Canicas[item.index] == 0 ? new int[] { 0, 0 } : new int[] { cantidad, (cantidad += Canicas[item.index]) }));
                Preguntas.ToList().ForEach(x => Console.WriteLine((dictionary[x][0] != 0 ? $"{x} found at {dictionary[x][0]}" : $"{x} not found")));
            }
            Console.ReadLine();
        }
    }
}