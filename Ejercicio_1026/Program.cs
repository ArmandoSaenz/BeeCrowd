using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;

namespace Ejercicio_1026
{

    internal class Program
    {

        static void Main(string[] args)
        {
            string data;
            while(!String.IsNullOrEmpty(data = Console.ReadLine()))
            {
                string[] datas = data.Split(' ');
                var value1 = uint.Parse(datas[0]);
                var value2 = uint.Parse(datas[1]);
                var value3 = value1 ^ value2;
                Console.WriteLine(value3);
            }
        }
    }
}
