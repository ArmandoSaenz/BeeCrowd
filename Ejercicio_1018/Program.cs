using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio_1018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicializando variables
            int num100, num50, num20, num10, num5, num2, num1;
            int valor = int.Parse(Console.ReadLine());
            int valor2 = valor;
            //Cantidad de billetes de 100
            num100 = valor / 100;
            //Restando la cantidad de billetesde 100
            valor -= num100 * 100;

            //Cantidad de billetes de 50
            num50 = valor / 50;
            //Restando la cantidad de billetesde 50
            valor -= num50 * 50;

            //Cantidad de billetes de 20
            num20 = valor / 20;
            //Restando la cantidad de billetesde 20
            valor -= num20 * 20;

            //Cantidad de billetes de 10
            num10 = valor / 10;
            //Restando la cantidad de billetesde 10
            valor -= num10 * 10;

            //Cantidad de billetes de 5
            num5 = valor / 5;
            //Restando la cantidad de billetesde 5
            valor -= num5 * 5;

            //Cantidad de billetes de 2
            num2 = valor / 2;
            //Restando la cantidad de billetesde 2
            valor -= num2 * 2;

            //Cantidad de billetes de 2
            num1 = valor;

            Console.WriteLine(valor2);
            Console.WriteLine($"{num100} nota(s) de R$ 100,00");
            Console.WriteLine($"{num50} nota(s) de R$ 50,00");
            Console.WriteLine($"{num20} nota(s) de R$ 20,00");
            Console.WriteLine($"{num10} nota(s) de R$ 10,00");
            Console.WriteLine($"{num5} nota(s) de R$ 5,00");
            Console.WriteLine($"{num2} nota(s) de R$ 2,00");
            Console.WriteLine($"{num1} nota(s) de R$ 1,00");

            Console.ReadLine();
        }
    }
}
