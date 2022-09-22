using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1244
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int D;
            string linea, tmp;
            string[] palabras;
            D = int.Parse(Console.ReadLine());
            for (int i = 0; i < D; i++)
            {
                linea = Console.ReadLine();
                palabras = linea.Split(' ');
                for (int j = 1; j < palabras.Length; j++)
                {
                    if (palabras[j - 1].Length < palabras[j].Length)
                    {
                        tmp = palabras[j - 1];
                        palabras[j - 1] = palabras[j];
                        palabras[j] = tmp;
                        j -= j == 1 ? 1 : 2;
                    }
                }
                Console.WriteLine(String.Join(" ", palabras));
            }
        }
    }
}
