using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1024
{
    internal class Program
    {
        static string Encriptar1(string data)
        {
            var palabra = data.ToList().Select(x => char.IsLetter(x) ? x + 3 : x);
            return String.Concat(palabra.Select(x => (char)x));
        }
        static string Encriptar2(string data)
        {
            var palabra = data.ToList().Select(x => x - 1);
            return String.Concat(palabra.Select(x => (char)x));
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            List<string> resultado = new List<string>();
            for (int i = 0; i < t; ++i)
            {
                string data = Console.ReadLine();
                int pos = data.Length / 2;
                data = Encriptar1(String.Concat(data.Reverse()));
                string subcadena = data.Substring(pos);
                data = data.Replace(subcadena, Encriptar2(subcadena));
                resultado.Add(data);
            }
            resultado.ForEach(x => Console.WriteLine(x));
        }
    }
}
