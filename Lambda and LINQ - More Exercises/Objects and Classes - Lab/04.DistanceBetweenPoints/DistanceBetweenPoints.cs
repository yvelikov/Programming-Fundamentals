namespace _04.DistanceBetweenPoints
{
    using System;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPoint = ReadPoints();
            var secondPoint = ReadPoints();

            var distance = CalcDistance(firstPoint, secondPoint);
            Console.WriteLine($"{distance:F3}");
        }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var distance = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X,2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
            return distance;
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
    }
}
