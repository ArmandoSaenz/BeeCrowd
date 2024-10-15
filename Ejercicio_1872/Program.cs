using System;
using System.Linq;

namespace Ejercicio_1872
{
    class Number
    {
        public string data;
        public string Data
        {
            get
            {
                return data;
            }
            private set
            {
                data = value;
                var parts = data.Split('.');
                Value = decimal.Parse(data);
                IntegerPart = parts[0];
                DecimalPart = parts.Length > 1 ? parts[1] : "";
                Integer = (int)(int.Parse(IntegerPart) * Math.Pow(10, NumbersOfDecimal - IntegerPart.Length));
                try
                {
                    Decimal = (int)(int.Parse(DecimalPart) * Math.Pow(10, NumbersOfDecimal - DecimalPart.Length));
                }
                catch 
                {
                    Decimal = 0;
                }
            }

        }
        public decimal Value { get; set; }
        public string ReverseString(string str) => string.Concat(str.Reverse());
        public bool IsPalindrome(string str) => str == ReverseString(str);
        public string IntegerPart { get; private set; }
        public string DecimalPart { get; private set; }
        public int Integer { get; private set; }
        public int Decimal { get; private set; }
        public bool IsDecimal => Data.Contains(".");
        public int NumbersOfDecimal => Math.Max(IntegerPart.Length, DecimalPart.Length);
        public Number(string _data)
        {
            Data = _data;
        }

        public string GetDifference()
        {
            if(IsPalindrome(Data))
            {
                return 0.ToString();
            }
            else if(!IsDecimal||Decimal==0)
            {
                return $"0.{ReverseString(IntegerPart)}";
            }
            int newvalue = (int)(int.Parse(ReverseString(IntegerPart)) * Math.Pow(10, NumbersOfDecimal - IntegerPart.Length));
            if (newvalue>=Decimal)
            {
                return ((newvalue - Decimal)/Math.Pow(10d,NumbersOfDecimal)).ToString($"F{NumbersOfDecimal}");
            }
            else
            {
                if (IsPalindrome((++Integer).ToString()))
                {
                    return (Integer - Value).ToString();
                }
                else
                {
                    var difference1 = Integer - Value;
                    var difference2 = (decimal)(int.Parse(ReverseString(Integer.ToString())) / Math.Pow(10d, NumbersOfDecimal));
                    return (difference1+difference2).ToString();
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string data;
            string result;
            Number number;
            n = int.Parse(Console.ReadLine());
            while (!String.IsNullOrEmpty((data = Console.ReadLine())))
            {
                number = new Number(data);
                for (result = number.GetDifference(); result != "0" && result.Last() == '0'; result = result.Remove(result.Length - 1, 1)) ;
                Console.WriteLine(result);
            }
        }
    }
}
