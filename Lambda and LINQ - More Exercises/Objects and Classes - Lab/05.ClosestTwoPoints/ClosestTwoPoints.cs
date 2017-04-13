namespace _05.ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class ClosestTwoPoints
    {
        private static int i;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Point>();

            for (int i = 0; i < n; i++)
            {
                var point = ReadPoints();
                points.Add(point);
            }

            var minDistance = double.MaxValue;
            Point firstPair = null;
            Point secondPair = null;
            for (int firstPoint = 0; firstPoint < points.Count; firstPoint++)
            {
                for (int secondPoint = firstPoint + 1; secondPoint < points.Count; secondPoint++)
                {
                    var distance = CalcDistance(points[firstPoint], points[secondPoint]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        firstPair = points[firstPoint];
                        secondPair = points[secondPoint];
                    }
                }
            }

            Console.WriteLine($"{minDistance:F3}");
            Console.WriteLine($"({firstPair.X}, {firstPair.Y})");
            Console.WriteLine($"({secondPair.X}, {secondPair.Y})");
        }

        public static Point ReadPoints()
        {
            var points = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var point = new Point()
            {
                X = points[0],
                Y = points[1]
            };

            return point;
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var distance = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
            return distance;
        }
    }
}
