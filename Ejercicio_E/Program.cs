using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Ejercicio_E
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            string[] values;
            int N, K, mod, can1, can2;
            int[] pos;
            data = Console.ReadLine();
            values = data.Split(' ');
            N = int.Parse(values[0]);
            K = int.Parse(values[1]);
            pos = new int[K];
            can1 = N / K;
            can2 = can1 + 1;
            mod = N % K;
            List<string> Students = new List<string>();
            while((data = Console.ReadLine()) != null)
                Students.Add(data);
            Students.Sort();
            for(int i = 1; i < K; ++i)
            {
                if(i )
                    pos[i] = 
            }


        }
    }
}
