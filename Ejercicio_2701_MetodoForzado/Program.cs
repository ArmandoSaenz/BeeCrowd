using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2701_MetodoForzado
{
    class NAND
    {
        public NAND Port1;
        public NAND Port2;
        public int output = -1;
        public int[] outputs = new int[] { 1, 1, 1, 0 };
        public int Getoutput()
        {
            return output >= 0 ? output : (outputs[Port1.Getoutput() + 2 * Port2.Getoutput()]);
        }

    }
    internal class Program
    {
        static void Increment(List<NAND> inputs)
        {
            int increment = 1;
            foreach (NAND input in inputs)
            {
                if (increment == 0)
                    break;
                if (input.output == 1)
                {
                    input.output = 0;
                }
                else
                {
                    input.output = 1;
                    increment = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            string line;
            int[] data;
            double patterns;
            double testcount = 0;
            double countzeros = 0;
            double countones = 0;
            NAND CurrentGate;
            NAND CurrentIdealGate;
            List<NAND> Gates;
            List<NAND> IdealGates;
            List<NAND> Inputs = new List<NAND>();
            int n = int.Parse(Console.ReadLine());
            Gates = Enumerable.Range(0, n).Select(_ => new NAND()).ToList();
            IdealGates = Enumerable.Range(0, n).Select(_ => new NAND()).ToList();
            for (int i = 0; i < n; ++i)
            {
                CurrentGate = Gates[i];
                CurrentIdealGate = IdealGates[i];
                line = Console.ReadLine();
                data = Array.ConvertAll<string, int>(line.Split(' '), int.Parse);
                if (data[0] == 0)
                {
                    NAND tmp = new NAND();
                    tmp.output = 0;
                    Inputs.Add(tmp);
                    CurrentGate.Port1 = tmp;
                    CurrentIdealGate.Port1 = tmp;
                }
                else
                {
                    CurrentGate.Port1 = Gates[data[0] - 1];
                    CurrentIdealGate.Port1 = IdealGates[data[0] - 1];
                }
                if (data[1] == 0)
                {
                    NAND tmp = new NAND();
                    tmp.output = 0;
                    Inputs.Add(tmp);
                    CurrentGate.Port2 = tmp;
                    CurrentIdealGate.Port2 = tmp;
                }
                else
                {
                    CurrentGate.Port2 = Gates[data[1] - 1];
                    CurrentIdealGate.Port2 = IdealGates[data[1] - 1];
                }
                CurrentGate.output = data[2];
            }
            patterns = Math.Pow(2, Inputs.Count);
            CurrentGate = Gates[0];
            CurrentIdealGate = IdealGates[0];
            for (int idx = 0; idx < patterns; ++idx)
            {
                //Inputs.ForEach(item => Console.Write(item.output));
                //Console.WriteLine($" - {CurrentGate.Getoutput()} - {CurrentIdealGate.Getoutput()}");
                if (CurrentIdealGate.Getoutput() == 0)
                {
                    ++countzeros;
                }
                else
                {
                    ++countones;
                }
                Increment(Inputs);
            }
            Console.WriteLine($"{countzeros}-{countones}");
            Console.ReadLine();
        }
    }
}
