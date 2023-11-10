using System;
using System.Collections.Generic;
using System.Linq;

namespace Ejercicio_1303
{
    class InfoTeam : IComparable<InfoTeam>
    {
        public int ID { get; set; }
        public List<int> ScoredPoints { get; } = new List<int>();
        public List<int> Points { get; } = new List<int>();
        public int TotalPoints { get; private set; } = 0;
        public bool WinAll { get; private set; } = true;
        public int TotalPointsScored { get; private set; } = 0;
        public int AverageBasket { get; private set; } = 0;

        public InfoTeam(int id)
        {
            ID = id;
        }

        public void AddGame(int scoredpoints, int points)
        {
            ScoredPoints.Add(scoredpoints);
            Points.Add(points);
            WinAll &= points == 2;
            TotalPointsScored += scoredpoints;
            TotalPoints += points;
            AverageBasket = TotalPointsScored == 0 ? TotalPoints :  TotalPointsScored / TotalPoints;
        }
        public int CompareTo(InfoTeam other)
        {
            int value = -this.TotalPoints.CompareTo(other.TotalPoints);
            if (value != 0)
                return value;
            else
            {
                value = -this.AverageBasket.CompareTo(other.AverageBasket);
                if (value != 0)
                    return value;
                else
                {
                    value = -this.TotalPointsScored.CompareTo(other.TotalPointsScored);
                    if (value != 0)
                        return value;
                    else
                        return this.ID.CompareTo(other.ID);
                }
            }
        }
    }
    class Program
    {
        static Comparer<InfoTeam> descendingComparer = Comparer<InfoTeam>.Create((x, y) => x.CompareTo(y));
        static void Main(string[] args)
        {
            int n, numberGames;
            List<InfoTeam> Teams;
            SortedList<InfoTeam, int> Rank;
            int[] data;
            int tc = 0;
            while((n = int.Parse(Console.ReadLine())) != 0)
            {
                ++tc;
                if(tc!=1)
                {
                    Console.WriteLine();
                }
                Teams = new List<InfoTeam>(n);
                for (int i = 0; i < n; ++i) 
                    Teams.Add(new InfoTeam(i+1));
                numberGames = n * (n - 1) / 2;
                for (int i = 0; i < numberGames; ++i)
                {
                    data = Array.ConvertAll<string, int>(Console.ReadLine().Split(' '), int.Parse);
                    if (data[1] > data[3])
                    {
                        Teams[data[0] - 1].AddGame(data[1], 2);
                        Teams[data[2] - 1].AddGame(data[3], 1);
                    }
                    else
                    {
                        Teams[data[0] - 1].AddGame(data[1], 1);
                        Teams[data[2] - 1].AddGame(data[3], 2);
                    }

                }
                Rank = new SortedList<InfoTeam, int>(Teams.ToDictionary(team => team, item => item.ID));
                string[] Positions = Array.ConvertAll<int, string>(Rank.Values.ToArray(), item => item.ToString());
                Console.WriteLine($"Instancia {tc}");
                Console.WriteLine(String.Join(" ", Positions));                
            }
        }
    }
}