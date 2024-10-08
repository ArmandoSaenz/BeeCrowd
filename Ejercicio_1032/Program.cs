using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Ejercicio_1032
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hasta el numero 32918 existen 3528 números primos
            List<int> primos = new List<int>() { 2 };
            List<int> persons;
            for(int i = 3; i < 32918; i+= 2)
            {
                if(primos.TrueForAll(item => i%item !=0))
                    primos.Add(i);
            }
            string data = "";
            while ((data = Console.ReadLine()) != "0")
            {
                persons = Enumerable.Range(1, int.Parse(data)).ToList();
                for(int idx =0, primo = 0, idxperson = 0; persons.Count>1; ++idx)
                {
                    primo = primos[idx];
                    idxperson += (primo - 1);
                    idxperson %= persons.Count;
                    persons.RemoveAt(idxperson);
                }
                Console.WriteLine(persons[0]);
            }
            Console.ReadLine();

        }
    }
}
