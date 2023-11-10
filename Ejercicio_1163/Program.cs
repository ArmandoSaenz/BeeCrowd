using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1163
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double g = 9.80665;
            double h = 0.0;
            int n = 0;
            double x0p, y0p, t, xf;
            double x0 = 0.0;

            int pos = 0;
            int inipos = 0;
            int endpos = 0;

            double AngDeg;
            double AngRad;
            double Vel;
            double _PI = 3.14159;
            string data;
            string[] values;

            while (!String.IsNullOrEmpty(data = Console.ReadLine()))
            {
                h = double.Parse(data);
                data = Console.ReadLine();
                values = data.Split(' ');
                inipos = int.Parse(values[0]);
                endpos = int.Parse(values[1]);
                data = Console.ReadLine();
                n = int.Parse(data);

                for (int i = 0; i < n; ++i)
                {
                    data = Console.ReadLine();
                    values = data.Split(' ');
                    AngDeg = double.Parse(values[0]);
                    Vel = double.Parse(values[1]);
                    AngRad = (AngDeg) * (_PI / 180.0);
                    x0p = Vel * Math.Cos(AngRad);
                    y0p = Vel * Math.Sin(AngRad);
                    //computing
                    t = (y0p + Math.Sqrt(Math.Pow(y0p, 2) + 2 * g * h)) / g;
                    xf = x0p * t + x0;
                    if (xf >= inipos && xf <= endpos)
                        Console.WriteLine($"{xf.ToString("F5")} -> DUCK");

                    else
                        Console.WriteLine($"{xf.ToString("F5")} -> NUCK");
                }
            }
            Console.ReadLine();
        }
    }
}
