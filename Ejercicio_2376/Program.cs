using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2376
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definición de variables
            List<char> Teams = new List<char>();
            List<char> Winners = new List<char>();
            string[] data;
            int a, b;
            //Construyendo los equipos
            for(int i = 0; i < 16; ++i)
            {
                Teams.Add((char)(65 + i));
            }
            //Resolviendo los octavos de final
            for(int i = 0; i < 8; ++i)
            {
                data = Console.ReadLine().Split(' ');
                a = int.Parse(data[0]);
                b = int.Parse(data[1]);
                if (a > b)
                    Teams.RemoveAt(i + 1);
                else
                    Teams.RemoveAt(i);
            }
            //Resolviendo los Cuartos de final
            for (int i = 0; i < 4; ++i)
            {
                data = Console.ReadLine().Split(' ');
                a = int.Parse(data[0]);
                b = int.Parse(data[1]);
                if (a > b)
                    Teams.RemoveAt(i + 1);
                else
                    Teams.RemoveAt(i);
            }
            //Resolviendo las semifinales
            for (int i = 0; i < 2; ++i)
            {
                data = Console.ReadLine().Split(' ');
                a = int.Parse(data[0]);
                b = int.Parse(data[1]);
                if (a > b)
                    Teams.RemoveAt(i + 1);
                else
                    Teams.RemoveAt(i);
            }
            //Resolviendo la final
            data = Console.ReadLine().Split(' ');
            a = int.Parse(data[0]);
            b = int.Parse(data[1]);
            if (a > b)
                Teams.RemoveAt(1);
            else
                Teams.RemoveAt(0);
            Console.WriteLine(Teams[0]);
            Console.ReadLine();
        }
    }
}
