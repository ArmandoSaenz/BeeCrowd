using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1023
{
    internal class Program
    {
        static double Truncado(double numero, int decimales) => Math.Truncate(numero*Math.Pow(10,decimales))/Math.Pow(10,decimales);
        static void Main(string[] args)
        {
            string data;
            SortedList<int, int> Datos = new SortedList<int, int>();
            int personas;
            int litros;
            int promediolitros;
            double totalpersonas, totallitros;
            double promedio;
            string[] valores;
            List<string> Respuesta = new List<string>();
            string prompt;
            for(int ciudad = 0; (data = Console.ReadLine()) != "0"; ++ciudad)
            {
                Datos.Clear();
                int count = int.Parse(data);
                prompt = $"Cidade# {ciudad + 1}:" + Environment.NewLine;
                totalpersonas = 0;
                totallitros = 0;
                for (int i = 0; i < count; ++i)
                {
                    data = Console.ReadLine();
                    valores = data.Split(' ');
                    personas = int.Parse(valores[0]);
                    litros = int.Parse(valores[1]);
                    totalpersonas += personas;
                    totallitros += litros;
                    promediolitros = litros/personas;
                    if (Datos.ContainsKey(promediolitros))
                        Datos[promediolitros] += personas;
                    else
                        Datos.Add(promediolitros, personas);
                }
                Datos.Distinct();
                var Promedios = Datos.Select(item => $"{item.Value}-{item.Key}").ToList();
                prompt += String.Join(" ", Promedios) + Environment.NewLine;
                promedio = totallitros / totalpersonas;
                prompt += $"Consumo medio: {Truncado(promedio,2).ToString("F2")} m3." + Environment.NewLine;
                Respuesta.Add(prompt);
            }
            Console.WriteLine(String.Join(Environment.NewLine, Respuesta));
            Console.ReadLine();
        }
    }
}
