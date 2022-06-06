using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1501
{
    internal class Program
    {
        static ulong Factorial(ulong value)
        {
            return value <= 1 ? 1 : value*Factorial(value-1); 
        }
        static int CountZeros(string cadena)
        {
            int zeros = 0;
            foreach(char caracter in cadena)
                zeros += caracter == '0' ? 1 : 0;
            return zeros;
        }
        static int CountDigits(string cadena)
        {
            /*int digits = 0;
            foreach (char caracter in cadena)
                digits += caracter != '0' ? 1 : 0;
            return digits;
            */
            return cadena.Length;
        }
        static string Digits2String(int number)
        {
            char digit;
            number += number < 10 ? 48 : 55;
            digit = (char)number;
            return digit.ToString();
        }
        static string C2Base(ulong num, ulong nbase)
        {
            string number = "";
            int residuo;
            if (nbase == 10)
                return num.ToString();
            do
            {
                residuo = (int)(num % nbase);
                num = num / nbase;
                number = Digits2String(residuo) + number;
            }
            while (num!=0);
            return number;
        }
        static void Main(string[] args)
        {
            string datos;
            string[] data;
            string resultado;
            ulong num, nbase;
            ulong factorial;
            do
            {
                datos = Console.ReadLine(); 
                if (String.IsNullOrEmpty(datos))
                    break;
                data = datos.Split(' ');
                num = ulong.Parse(data[0]);
                nbase = ulong.Parse(data[1]);
                factorial = Factorial(num);
                resultado = C2Base(factorial, nbase);
                Console.WriteLine("{0} {1}", CountZeros(resultado), CountDigits(resultado));
            }
            while (true);
        }
    }
}
