using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_1104
{
    class Program
    {
        static void Main(string[] args)
        {
            const string end = "0 0";
            string data;
            
            int uniqueCards;
            while((data = Console.ReadLine()) != end)
            {
                var cards1 = Console.ReadLine().Split(' ').Distinct().ToList();
                var cards2 = Console.ReadLine().Split(' ').Distinct().ToList();
                if(cards1.Count < cards2.Count)
                {
                    var cards = cards1.Except(cards2).ToList();
                    Console.WriteLine(cards.Count());
                }
                else
                {
                    var cards = cards2.Except(cards1).ToList();
                    Console.WriteLine(cards.Count());
                }
            }
        }
    }
}