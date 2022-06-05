using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flores_de_Fuego
{
    internal class Program
    {
        //Rutina para convertir un vector de string a vector de double
        static double[] S2D(string[] list)
        {
            int c = list.GetLength(0);
            double[] val = new double[c];
            for (int i = 0; i < c; i++)
            {
                val[i] = double.Parse(list[i]);
            }
            return val;
        }
        //Función para obtener la norma en un plano
        static double Norma2D(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
        static void Main(string[] args)
        {
            //Definiendo variables
            string reg;
            string[] datos;
            double[] data;
            double rf, rc;
            double xf, yf, xc, yc;
            double distancia;
            string resultado;
            //Ciclo infinito
            while (true)
            {
                reg = Console.ReadLine(); //Obtiene el registro
                if (String.IsNullOrEmpty(reg)) //Finaliza si encuentro el EOF
                    break;
                datos = reg.Split(' ');//Separa los datos
                data = S2D(datos);//Convierte los datos a double
                //Cambio de variable
                rc = data[0];
                xc = data[1];
                yc = data[2];
                rf = data[3];
                xf = data[4];
                yf = data[5];
                distancia = Norma2D(xf - xc, yf - yc);
                resultado = rc < distancia + rf ? "MORTO" : "RICO";
                Console.WriteLine(resultado);
            }
        }
    }
}
