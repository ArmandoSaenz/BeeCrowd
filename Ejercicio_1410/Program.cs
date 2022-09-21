using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1410
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int A = 0, D = 0;
                int[] B = null;
                int[] C = null;
                int aux = 0;
                string input0 = "";
                string inputA = "";
                string inputB = "";

                input0 = Console.ReadLine();
                if (input0 == "0 0")
                    break;

                string[] resultado0 = input0.Split(' ');

                A = int.Parse(resultado0[0]);


                D = int.Parse(resultado0[1]);

                B = new int[A];
                C = new int[D];

                inputA = Console.ReadLine();
                string[] resultadoA = inputA.Split(' ');

                for (int i = 0; i < B.Length; i++)
                {
                    B[i] = int.Parse(resultadoA[i]);

                }

                inputB = Console.ReadLine();
                string[] resultadoB = inputB.Split(' ');

                for (int i = 0; i < C.Length; i++)
                {
                    C[i] = int.Parse(resultadoB[i]);

                }

                for (int i = 0; i < C.Length; i++)
                {
                    for (int j = 0; j < C.Length; j++)
                    {
                        aux = C[i];
                        if (aux < C[j])
                        {
                            aux = C[j];
                            C[j] = C[i];
                            C[i] = aux;
                        }
                    }
                }

                for (int i = 0; i < B.Length; i++)
                {
                    for (int j = 0; j < B.Length; j++)
                    {
                        aux = B[i];
                        if (aux < B[j])
                        {
                            aux = B[j];
                            B[j] = B[i];
                            B[i] = aux;
                        }
                    }
                }
                if (B[0] < C[1])
                    Console.WriteLine('Y');
                else
                    Console.WriteLine('N');
            }
        }
    }
}
