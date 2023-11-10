using System;
using System.Linq;

namespace Ejercicio_1287
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            int num;
            while ((data = Console.ReadLine()) != null)
            {
                data = String.Concat<char>(data.ToList().FindAll(item => item != ' ' && item != ','));
                data = data.Replace("o", "0").Replace("O", "0").Replace("l", "1");
                
                if(data.Length > 0 && int.TryParse(data,out num))
                {
                    Console.WriteLine(num.ToString());
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }
}
