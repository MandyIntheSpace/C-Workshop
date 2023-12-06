using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop6
{
    internal class Point2D
    {
        public float X;
        public float Y;

        public Point2D(float x, float y)
        {
            X = x;
            Y = y;
        }

        public class Geometry
        {
            public static double CalculateDistance(Point2D point1, Point2D point2)
            {
                return Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            }
        }

        public class Program
        {
            public static void Main()
            {
                Point2D point1 = new Point2D(3, 4);
                Point2D point2 = new Point2D(0, 0);

                double distance = Geometry.CalculateDistance(point1, point2);
                Console.WriteLine($"Distance between points: {distance}");
            }
        }

    }




}
