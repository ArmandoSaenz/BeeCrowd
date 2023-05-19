using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3002
{
    internal class Program
    {
        static bool IsPrime(int number)
        {
            if(number%2==0 && number > 2)
                return false;
            int max = (int)Math.Ceiling(Math.Sqrt(number));
            if (max * max == number)
                return false;
            for (int i = 3; i < max; i += 2)
                if (number % i == 0) return false;
            return true;
        }
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            int number = int.Parse(data);
            if (number % 2 == 0 && number > 2)
                Console.WriteLine(2);
            else if(IsPrime(number))
                Console.WriteLine(1);
            else if(IsPrime(number-2))
                Console.WriteLine(2);
            else
                Console.WriteLine(3);
            Console.ReadLine();
        }
    }
}
