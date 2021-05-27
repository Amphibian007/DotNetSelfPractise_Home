using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodPractise
{
    public static class AllMethods
    {
        public static Distance GetDistance(this Point point1, Point point2)
        {
            Console.WriteLine($"The distance is {point1.X-point2.X} and {point1.Y-point2.Y}");
            Distance distance = new Distance();
            distance.XDistance = point2.X - point1.X;
            distance.YDistance = point2.Y - point1.Y;
            return distance;
        }
        
    }
}
