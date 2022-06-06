using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1501
{
    internal class Program
    {
        //public variables
        static int index = (1 << 20) + 20;
        static double[] li = new double[index];
        //Algorithm to count zeros
        static int CountZeros(int num, int nbase)
        {
            int iterations = 0;
            int t=0;
            int b = nbase;
            int c = 0;
            int p = 2;
            //Compute the blocks of least significant zaros
            for(int i = 2; i<=b; ++i)
            {
                if (b % i == 0)
                {
                    c = 0;
                    while(b%i==0)
                    {
                        c++;
                        b /= i;
                    }
                    p = i;
                }
            }
            //Compute the least significant zeros count 
            while(num>0)
            {
                num /= p;
                t += num;
            }
            return t / c;
        }
        static int CountDigits(int num, int nbase)
        {
            return (int)Math.Round(Math.Floor(li[num]) / Math.Log(nbase) + 1);
        }
        //Main function
        static void Main(string[] args)
        {
            //local variables
            string datos;
            string[] data;
            int num, nbase;
            for (int i = 1; i < index; ++i)
                li[i] = li[i - 1] + Math.Log(i);
            do
            {
                datos = Console.ReadLine(); 
                if (String.IsNullOrEmpty(datos))
                    break;
                data = datos.Split(' ');
                num = int.Parse(data[0]);
                nbase = int.Parse(data[1]);
                Console.WriteLine("{0} {1}", CountZeros(num,nbase), CountDigits(num, nbase));
            }
            while (true);
        }
    }
}
