using System;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {
        List<int> actual = new List<int>();
        List<int> anterior = new List<int>();
        List<int> siguiente = new List<int>();
        string registro, posinicial, posfinal;
        string[] datos;
        int final;
        int pos;
        int movimientos = 0;
        do
        {
            registro = Console.ReadLine();
            if (String.IsNullOrEmpty(registro) || String.IsNullOrWhiteSpace(registro))
                break;
            datos = registro.Split(' ');
            posinicial = datos[0];
            posfinal = datos[1];
            siguiente.Clear();
            anterior.Clear();
            siguiente.Add(string2cord(posinicial));
            final = string2cord(posfinal);
            movimientos = 0;
            do
            {
                movimientos++;
                actual.Clear();
                foreach (int cord in siguiente)
                {
                    actual.Add(cord);
                }
                siguiente.Clear();
                while (actual.Count > 0)
                {
                    //movimiento hacia la derecha
                    if (actual[0] < 70 && actual[0] - ((actual[0] / 10) * 10) < 8)
                    {
                        pos = actual[0] + 21;
                        if (!actual.Contains(pos) && !anterior.Contains(pos))
                            siguiente.Add(pos);
                    }
                    if (actual[0] < 70 && actual[0] - ((actual[0] / 10) * 10) > 1)
                    {
                        pos = actual[0] + 19;
                        if (!actual.Contains(pos) && !anterior.Contains(pos))
                            siguiente.Add(pos);
                    }
                    //movimientod hacia abajo
                    if (actual[0] < 80 && actual[0] - ((actual[0] / 10) * 10) > 2)
                    {
                        pos = actual[0] + 8;
                        if (!actual.Contains(pos) && !anterior.Contains(pos))
                            siguiente.Add(pos);
                    }
                    if (actual[0] > 20 && actual[0] - ((actual[0] / 10) * 10) > 2)
                    {
                        pos = actual[0] - 12;
                        if (!actual.Contains(pos) && !anterior.Contains(pos))
                            siguiente.Add(pos);
                    }
                    //movimientos hacia la izquierda
                    if (actual[0] > 30 && actual[0] - ((actual[0] / 10) * 10) > 1)
                    {
                        pos = actual[0] - 21;
                        if (!actual.Contains(pos) && !anterior.Contains(pos))
                            siguiente.Add(pos);
                    }
                    if (actual[0] > 30 && actual[0] - ((actual[0] / 10) * 10) < 8)
                    {
                        pos = actual[0] - 19;
                        if (!actual.Contains(pos) && !anterior.Contains(pos))
                            siguiente.Add(pos);
                    }
                    //Movimientos hacia arriba
                    if (actual[0] > 20 && actual[0] - ((actual[0] / 10) * 10) < 7)
                    {
                        pos = actual[0] - 8;
                        if (!actual.Contains(pos) && !anterior.Contains(pos))
                            siguiente.Add(pos);
                    }
                    if (actual[0] < 80 && actual[0] - ((actual[0] / 10) * 10) < 7)
                    {
                        pos = actual[0] + 12;
                        if (!actual.Contains(pos) && !anterior.Contains(pos))
                            siguiente.Add(pos);
                    }
                    anterior.Add(actual[0]);
                    actual.Remove(actual[0]);
                }

            }
            while (!siguiente.Contains(final));
            Console.WriteLine("To get from {0} to {1} takes {2} knight moves.", datos[0], datos[1], movimientos);
        }
        while (true);
    }
    static int string2cord(string arg)
    {
        int resultado = 0;
        switch (arg[0])
        {
            case 'a':
                resultado = 10;
                break;
            case 'b':
                resultado = 20;
                break;
            case 'c':
                resultado = 30;
                break;
            case 'd':
                resultado = 40;
                break;
            case 'e':
                resultado = 50;
                break;
            case 'f':
                resultado = 60;
                break;
            case 'g':
                resultado = 70;
                break;
            case 'h':
                resultado = 80;
                break;
        }
        resultado += int.Parse(arg[1].ToString());
        return resultado;
    }

}