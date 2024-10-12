using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Ejercicio_2701
{
    class NAND
    {
        public NAND Port1;
        public NAND Port2;
        public int output = -1;
        public double posibilities = 0;
        public double countzeros = 0;
        public double countones = 0;
        public bool ComputeZeros = false;
        public double GetPosibilities()
        {
            posibilities = Port1 == null ? 2 : Port1.GetPosibilities();
            posibilities *= Port2 == null ? 2 : Port2.GetPosibilities();
            return posibilities;
        }
        public double GetZeros()
        {
            double ones1 = Port1 == null ? 1 : Port1.GetOnes();
            double ones2 = Port2 == null ? 1 : Port2.GetOnes();
            countzeros = ones1 * ones2;
            countones = posibilities - countzeros;
            ComputeZeros = true;
            return countzeros;
        }

        public double GetRealZeros()
        {
            switch(output)
            {
                case 0:
                    return posibilities;
                case 1:
                    return 0;
                default:
                    double ones1 = Port1 == null ? 1 : Port1.GetOnes();
                    double ones2 = Port2 == null ? 1 : Port2.GetOnes();
                    countzeros = ones1 * ones2;
                    return countzeros;
            }
        }

        public double GetRealOnes()
        {
            switch (output)
            {
                case 0:
                    return 0;
                case 1:
                    return posibilities;
                default:
                    return posibilities - GetRealZeros();
            }
        }
        public double GetOnes()
        {
            if (!ComputeZeros)
                GetZeros();
            return countones;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            int[] data;
            double patterns;
            NAND CurrentGate;
            List<NAND> Gates;
            List<NAND> Inputs = new List<NAND>();
            int n = int.Parse(Console.ReadLine());
            Gates = Enumerable.Range(0, n).Select(_ => new NAND()).ToList();
            for (int i = 0; i < n; ++i)
            {
                CurrentGate = Gates[i];
                line = Console.ReadLine();
                data = Array.ConvertAll<string, int>(line.Split(' '), int.Parse);
                CurrentGate.Port1 = data[0] == 0? null: Gates[data[0] - 1];
                CurrentGate.Port2 = data[1] == 0 ? null : Gates[data[1] - 1];
                CurrentGate.output = data[2];
            }
            patterns = Math.Pow(2, Inputs.Count);
            CurrentGate = Gates[0];
            Console.WriteLine($"Combinaciones posibles = {CurrentGate.GetPosibilities()}");
            var zeros = CurrentGate.GetZeros();
            var ones = CurrentGate.GetOnes();
            var realZeros = CurrentGate.GetRealZeros();
            var realOnes = CurrentGate.GetRealOnes();
            Console.WriteLine($"Cantidad de ceros = {zeros}");
            Console.WriteLine($"Cantidad de unos = {ones}");
            Console.WriteLine($"Cantidad de ceros reales = {realZeros}");
            Console.WriteLine($"Cantidad de unos reales = {realOnes}");
            patterns = realZeros <= zeros ? zeros - realZeros : 0;
            Console.WriteLine($"Resultados {patterns}");
            patterns += realOnes <= ones ? ones - realOnes : 0;
            Console.WriteLine($"Resultados {patterns%(10E9 + 7)}");
            Console.ReadLine();
        }
    }
}