﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1031
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> Resultado = new Dictionary<int, int>()
            {
                {13,1},{14,18},{15,10},{16,11},{17,7},{18,17},{19,11},{20,15},
                {21,29},{22,5},{23,21},{24,13},{25,26},{26,14},{27,11},{28,23},{29,22},{30,9},
                {31,73},{32,17},{33,42},{34,7},{35,98},{36,15},{37,61},{38,22},{39,84},{40,24},
                {41,30},{42,9},{43,38},{44,15},{45,54},{46,27},{47,9},{48,61},{49,38},{50,22},
                {51,19},{52,178},{53,38},{54,53},{55,79},{56,68},{57,166},{58,20},{59,9},{60,22},
                {61,7},{62,21},{63,72},{64,133},{65,41},{66,10},{67,82},{68,92},{69,64},{70,129},
                {71,86},{72,73},{73,67},{74,19},{75,66},{76,115},{77,52},{78,24},{79,22},{80,176},
                {81,10},{82,57},{83,137},{84,239},{85,41},{86,70},{87,60},{88,116},{89,81},{90,79},
                {91,55},{92,102},{93,49},{94,5},{95,22},{96,54},{97,52},{98,113},{99,15},{100,66}
            };
            for(string data; (data=Console.ReadLine())!="0";)
            {
                Console.WriteLine(Resultado[int.Parse(data)]);
            }
        }
    }
}
