using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1549
{
    internal class Program
    {
        static double CokeHeight(double _lp, double _b, double _B, double _H)
        {
            if (_b == _B)
            {
                return _lp / (Math.PI * _B * _B); //Cilindro
            }
            else
            {
                double x = _b * _H / (_B - _b);
                double num = Math.Pow(_H + x, 2) * (3 * _lp + Math.PI * _b * _b * x);
                double den = Math.PI * _B * _B;
                double cube = Math.Pow(num / den, 1d / 3d);
                return cube - x; //Cono
            }
        }

        static double GlassVolume(double _b, double _B, double _H)
        {
            if (_B == _b) 
                return Math.PI * _b * _b * _H;//Cilindro
            else 
                return Math.PI / 3 * _H * (_B * _B + _B * _b + _b * _b);//Cono
        }
        static void Main(string[] args)
        {
            int C, N;
            double L, b, B, H, h, vp, vg;
            string data;
            string[] datos;
            C = int.Parse(Console.ReadLine());
            for(int i = 0; i < C; i++)
            {
                data = Console.ReadLine();
                datos = data.Split(' ');
                (N, L) = (int.Parse(datos[0]), double.Parse(datos[1]));
                data = Console.ReadLine();
                datos = data.Split(' ');
                (b, B, H) = (double.Parse(datos[0]), double.Parse(datos[1]), double.Parse(datos[2]));
                vg = GlassVolume(b, B, H);
                vp = L / N;
                h = vp >= vg ? H : CokeHeight(vp, b, B, H);
                Console.WriteLine(h.ToString("F2"));
            }
        }
    }
}
