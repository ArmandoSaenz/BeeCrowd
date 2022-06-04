using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarRating
{
    internal class Program
    {
        static string[] StarRating(string rating, int stars)
        {
            double rate;
            rate = double.Parse(rating);
            string[] images = new string[stars];
            for (int i = 0; i < stars; i++)
            {
                if (rate > i + 1)
                {
                    images[i] = "full";
                    continue;
                }
                if (rate > i && rate < i + 1)
                {
                    images[i] = "half";
                    continue;
                }
                images[i] = "empty";
            }
            return images;
        }
        static void Main(string[] args)
        {
            string[] starrate;
            string avg;
            avg = Console.ReadLine();
            starrate = StarRating(avg, 5);
            Console.WriteLine(String.Join(" ", starrate));
            Console.ReadLine();

        }
    }
}
