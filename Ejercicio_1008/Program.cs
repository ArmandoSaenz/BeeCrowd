using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string idEmpleado;
            int horas;
            float salarioDiario;
            float salarioMensual;
            idEmpleado = Console.ReadLine();
            horas = int.Parse(Console.ReadLine());
            salarioDiario = float.Parse(Console.ReadLine());
            salarioMensual = horas * salarioDiario;
            Console.WriteLine("NUMBER = {0}", idEmpleado);
            Console.WriteLine("SALARY = U$ {0}", salarioMensual.ToString("F2"));
        }
    }
}
