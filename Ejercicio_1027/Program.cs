using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1027
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            FncCiclica funcion = new FncCiclica();
            while (int.TryParse(Console.ReadLine(), out n))
            {
                funcion.Clear();
                for (int i = 0; i < n; i++)
                {
                    funcion.Add(new Point(Console.ReadLine()));
                }
                funcion.Sort();
                var lista = funcion.GetPossibleMatches(FncCiclica.PointType.Min);
                var maxvalue = lista.Values.Max();
                var point = lista.First(item => item.Value == maxvalue).Key;
                var matches = funcion.GetMatches(point);
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
            if (x.CompareTo(pointb.x) != 0)
                return x.CompareTo(pointb.x);
            else
                return y.CompareTo(pointb.y);
        }
    }
    class FncCiclica : List<Point>
    {
        public enum PointType
        {
            Max,
            Min
        };
        public Dictionary<Point, int> GetPossibleMatches(PointType pt = PointType.Min) => this.ToDictionary(point => point, point=> this.Count(item => item.x > point.x && (item.y==point.y || (pt == PointType.Min ? item.y - point.y  : point.y - item.y) == 2)));
        public List<Point> GetMatches(Point pointa, PointType pt = PointType.Min) => this.FindAll(pointb => pointb.x > pointa.x && (pointb.y == pointa.y || (pt == PointType.Min ? pointb.y - pointa.y : pointa.y - pointb.y) == 2));
        public List<Point> Filter(List<Point> matches, PointType pt = PointType.Min)
        {
            
        }
    }

}
