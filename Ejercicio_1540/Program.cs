using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1540
{
    internal class Program
    {
        static double Derivate(double fx1, double fx2, double t1, double t2)
        {
            return (fx2 - fx1) / (t2 - t1);
        }
        static double Truncate(double value, int decimals)
        {
            double exp = Math.Pow(10, (double)decimals);
            return Math.Floor(value * exp) / exp;
        }
        static void Main(string[] args)
        {
            string sreg;
            int nreg;
            string reg;
            string[] data;
            double fx1, fx2, t1, t2;
            double rate;
            sreg = Console.ReadLine();
            nreg = int.Parse(sreg);
            for(int i = 0; i < nreg; i++)
            {
                reg = Console.ReadLine();
                data = reg.Split(' ');
                t1 = double.Parse(data[0]);
                fx1 = double.Parse(data[1]);
                t2 = double.Parse(data[2]);
                fx2 = double.Parse(data[3]);
                rate = Derivate(fx1, fx2, t1, t2);
                Console.WriteLine(Truncate(rate, 2).ToString("F2").Replace('.',','));
            }
        }
    }
}
