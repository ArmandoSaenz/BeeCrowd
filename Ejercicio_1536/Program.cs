using System;

namespace Ejercicio_1536
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data;
            string[] values;
            int games;
            int score1_l, score1_v, score2_l, score2_v;
            int point1, point2;
            data = Console.ReadLine();
            games = int.Parse(data);
            for (int i = 0; i < games; ++i)
            {
                data = Console.ReadLine();
                values = data.Split('x');
                score1_l = int.Parse(values[0].Trim());
                score2_v = int.Parse(values[1].Trim());
                data = Console.ReadLine();
                values = data.Split('x');
                score2_l = int.Parse(values[0].Trim());
                score1_v = int.Parse(values[1].Trim());
                point1 = 0;
                point2 = 0;
                //Puntos del primer juego
                switch(Math.Sign(score1_l-score2_v))
                {
                    case 1:
                        point1 += 3;
                        break;
                    case -1:
                        point2 += 3;
                        break;
                    case 0:
                        ++point1;
                        ++point2;
                        break;
                }
                //Puntos del segundo juego
                switch (Math.Sign(score1_v - score2_l))
                {
                    case 1:
                        point1 += 3;
                        break;
                    case -1:
                        point2 += 3;
                        break;
                    case 0:
                        ++point1;
                        ++point2;
                        break;
                }
                //Determinando ganador
                switch(Math.Sign(point1-point2))
                {
                    case 1:
                        Console.WriteLine("Time 1");
                        break;
                    case -1:
                        Console.WriteLine("Time 2");
                        break;
                    case 0:
                        switch(Math.Sign(score1_v-score2_v))
                        {
                            case 1:
                                Console.WriteLine("Time 1");
                                break;
                            case -1:
                                Console.WriteLine("Time 2");
                                break;
                            case 0:
                                Console.WriteLine("Penaltis");
                                break;
                        }
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
