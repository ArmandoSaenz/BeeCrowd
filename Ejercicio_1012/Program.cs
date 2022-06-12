using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datos;
            string[] data;
            double a, b, c;
            double triangulo, circulo, trapecio, cuadrado, rectangulo;
            double pi = 3.14159f;
            datos = Console.ReadLine();
            data = datos.Split(' ');
            a = double.Parse(data[0]);
            b = double.Parse(data[1]);
            c = double.Parse(data[2]);
            triangulo = a * c / 2f;
            circulo = pi * c * c;
            trapecio = (a + b) * c / 2f;
            cuadrado = b * b;
            rectangulo = a * b;
            Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: {0}", trapecio.ToString("F3"));
            Console.WriteLine("QUADRADO: {0}", cuadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: {0}", rectangulo.ToString("F3"));
        }
    }
}
