using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1701
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] fibs = new long[10000];
            fibs[0] = 0;
            fibs[1] = 1;
            long mod = 1000000007;
            string line;
            string[] data;
            int A, B, N;
            long result;
            const string eof = "0 0 0";
            for(int i = 2; i < 10000; ++i)
            {
                fibs[i] = (fibs[i - 1] % mod + fibs[i - 2] % mod) % mod;  
            }
            while ((line = Console.ReadLine())!= eof)
            {
                data = line.Split(' ');
                A = int.Parse(data[0]);
                B = int.Parse(data[1]);
                N = int.Parse(data[2]);
                result = 0;
                for (int i = 2; i < N; ++i, ++A, ++B)
                {
                    result += ((fibs[A]%mod) * (fibs[A] % mod))%mod;
                }
                Console.WriteLine(result);
            }
        }
    }
}
