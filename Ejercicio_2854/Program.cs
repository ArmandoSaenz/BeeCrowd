using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2854
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            string[] values;
            string person1;
            string person2;
            int M, N;
            List<List<string>> Families = new List<List<string>>();
            List<string[]> Relations = new List<string[]>();
            data = Console.ReadLine();
            values = data.Split(' ');
            M = int.Parse(values[0]);
            N = int.Parse(values[1]);
            for(int i = 0; i < N; ++i)
            {
                data = Console.ReadLine();
                values = data.Split(' ');
                Relations.Add(values);
            }
            for(int idfamily = 0; Relations.Count > 0; ++idfamily)
            {
                Families.Add(new List<string>());
                values = Relations[0];
                Relations.Remove(values);
                Families[idfamily].Add(values[0]);
                Families[idfamily].Add(values[2]);
                for (int idperson = 0; idperson < Families[idfamily].Count && Relations.Count > 0; ++idperson)
                {
                    person1 = Families[idfamily][idperson];
                    proceso:
                    values = Relations.FirstOrDefault(relation => relation.Contains(person1));
                    if (values == null)
                        continue;
                    Relations.Remove(values);
                    person2 = person1 == values[0] ? values[2] : values[0];
                    if (!Families[idfamily].Contains(person2))
                        Families[idfamily].Add(person2);
                    goto proceso;
                }
            }
            Console.WriteLine(Families.Count());
            Console.ReadLine();
        }
    }
}
