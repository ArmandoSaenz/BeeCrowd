using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio_2701_2
{
    class NAND
    {
        public int Input1;
        public int Input2;
        public double totalinputs = 0;
        public double zeros = 0;
        public double ones = 0;
        public double realzeros = 0;
        public double realones = 0;
        public double Limit = 1000000007;
        public List<NAND> Circuit { get; set; }
        public virtual void Process()
        {
            var gate1 = Circuit[Input1];
            var gate2 = Circuit[Input2];
            gate1.Process();
            gate2.Process();
            totalinputs = (gate1.totalinputs * gate2.totalinputs);
            zeros = (gate1.ones * gate2.ones);
            ones = (totalinputs - zeros);
            realzeros = (gate1.realones * gate2.realones);
            realones = (totalinputs - realzeros);
            totalinputs %= Limit;
            zeros %= Limit;
            ones %= Limit;
            realzeros %= Limit;
            realones %= Limit;
        }
    }
    class INAND : NAND
    {
        public INAND()
        {
            zeros = 1;
            ones = 1;
            realzeros = 1;
            realones = 1;
            totalinputs = 2;
        }
        public override void Process()
        {
            //
        }
    }

    class NAND0 : NAND
    {
        public override void Process()
        {
            var gate1 = Circuit[Input1];
            var gate2 = Circuit[Input2];
            gate1.Process();
            gate2.Process();
            totalinputs = (gate1.totalinputs * gate2.totalinputs);
            zeros = (gate1.ones * gate2.ones);
            ones = (totalinputs - zeros);
            totalinputs %= Limit;
            zeros %= Limit;
            ones %= Limit;
            realzeros = totalinputs;
            realones = 0;
        }
    }
    class NAND1 : NAND
    {
        public override void Process()
        {
            var gate1 = Circuit[Input1];
            var gate2 = Circuit[Input2];
            gate1.Process();
            gate2.Process();
            totalinputs = (gate1.totalinputs * gate2.totalinputs);
            zeros = (gate1.ones * gate2.ones);
            ones = (totalinputs - zeros);
            totalinputs %= Limit;
            zeros %= Limit;
            ones %= Limit;
            realzeros = 0;
            realones = totalinputs;
            
        }

    }

    class Program
    {
        static void Main()
        {
            List<NAND> Gates = new List<NAND>();
            const double Limit = 1000000007;
            int n = int.Parse(Console.ReadLine());
            Gates.AddRange(Enumerable.Range(0, n).Select(_ =>
            {
                var line = Console.ReadLine();
                var data = line.Split(' ');
                int input1 = int.Parse(data[0]);
                int input2 = int.Parse(data[1]);
                int type = int.Parse(data[2]);
                input1 = input1 == 0 ? n : input1 - 1;
                input2 = input2 == 0 ? n : input2 - 1;
                switch (type)
                {
                    case 0:
                        return new NAND0() { Circuit = Gates, Input1 = input1, Input2 = input2 };
                    case 1:
                        return new NAND1() { Circuit = Gates, Input1 = input1, Input2 = input2 };
                    default:
                        return new NAND() { Circuit = Gates, Input1 = input1, Input2 = input2 };
                }
            }
            ));
            Gates.Add(new INAND());
            var OutGate = Gates[0];
            OutGate.Process();
            var testcases = (OutGate.zeros - OutGate.realzeros) % Limit;
            Console.WriteLine(Math.Abs(testcases));
        }
    }
}