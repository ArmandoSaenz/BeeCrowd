using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Ejercicio_1027
{
    internal class Program
    {
        enum State { down, up };
        static int CountPoints(List<Point> points, int x, int value, State state)
        {
            value += state == State.up ? 2 : -2;
            Point point = points.Find(item => item.x > x && item.y == value);
            if(point != null)
                return 1 + CountPoints(points, point.x, point.y, state == State.up?State.down: State.up);
            return 0;
        }
        static void Main(string[] args)
        {
            int n;
            List<Point> Points = new List<Point>();
            while (int.TryParse(Console.ReadLine(), out n))
            {
                Points.Clear();
                for (; n > 0; --n)
                {
                    Points.Add(new Point(Console.ReadLine()));
                }
                Points.Sort();
                Console.WriteLine(Points.Max(point => Math.Max(CountPoints(Points, point.x, point.y, State.up), CountPoints(Points, point.x, point.y, State.down)) + 1 ));
            }
        }
    }
    class Point : IComparable
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Point(string cadena)
        {
            string[] data = cadena.Split(' ');
            this.x = int.Parse(data[0]);
            this.y = int.Parse(data[1]);
        }
        public int CompareTo(object obj)
        {
            Point pointb = obj as Point;
            return x.CompareTo(pointb.x);
        }
    }
}
