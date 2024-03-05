using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1021
{
    class Money
    {
        public bool Title { get; private set; }
        public int Value { get; private set; }
        public int Count { get; private set; }
        public string Message { get; set; }

        public Money(int values, string message)
        {
            Value = values;
            Message = message;
            Title = false;
        }
        public Money(string message)
        {
            Message = message;
            Title = true;
        }
        public int Compute(int cash)
        {
            Count = cash / Value;
            return cash % Value;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Money> Change = new List<Money>() { new Money("NOTAS:"),
                                                     new Money(10000, "{0} nota(s) de R$ 100.00"),
                                                     new Money(5000, "{0} nota(s) de R$ 50.00"),
                                                     new Money(2000, "{0} nota(s) de R$ 20.00"),
                                                     new Money(1000, "{0} nota(s) de R$ 10.00"),
                                                     new Money(500, "{0} nota(s) de R$ 5.00"),
                                                     new Money(200, "{0} nota(s) de R$ 2.00"),
                                                     new Money("MOEDAS:"),
                                                     new Money(100, "{0} moeda(s) de R$ 1.00"),
                                                     new Money(50, "{0} moeda(s) de R$ 0.50"),
                                                     new Money(25, "{0} moeda(s) de R$ 0.25"),
                                                     new Money(10, "{0} moeda(s) de R$ 0.10"),
                                                     new Money(5, "{0} moeda(s) de R$ 0.05"),
                                                     new Money(1, "{0} moeda(s) de R$ 0.01")
                                                    };
            int mount = (int)(double.Parse(Console.ReadLine()) * 100);
            foreach (Money money in Change)
            {
                if (money.Title)
                {
                    Console.WriteLine(money.Message);
                }
                else
                {
                    mount = money.Compute(mount);
                    Console.WriteLine(money.Message, money.Count);
                }
            }
            Console.ReadLine();
        }
    }
}
