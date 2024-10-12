using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_1872
{
    internal class Program
    {
        static string ReverseString(string str) => string.Concat(str.Reverse());
        static bool IsPalindrome(string str) => str == ReverseString(str);

        static void Main(string[] args)
        {
            int n;
            string data;
            decimal entero, decimales;
            decimal numero;
            int dim1, dim2;
            string[] partes;
            decimal increment;
            n = int.Parse(Console.ReadLine());
            while (!String.IsNullOrEmpty((data = Console.ReadLine())))
            {
                if (IsPalindrome(data))
                {
                    Console.WriteLine("0");
                    continue;
                }
                //Obteniendo el numero
                numero = decimal.Parse(data);
                //Separando enteros y decimales
                partes = data.Split('.');
                //Contando digitos de la parte entera
                dim1 = partes[0].Length;
                //Contando digitos de la parte decimal
                dim2 =  partes.Length == 2 ? partes[1].Length : 0;
                increment = (decimal)Math.Pow(10, -Math.Max(dim1, dim2));
                for (; !IsPalindrome(numero.ToString()); numero += increment) ;
            }
        }
    }
}
