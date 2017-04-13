namespace _05.Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static int CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var distance = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X,2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
            return (int)distance;
        }
    }

    public class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }

        public static int CalculatePerimeter(int width, int height)
        {
            int parameter = 2*width+2*height;
            return parameter;
        }

        public static int CalculateArea(int width, int height)
        {
            int area = width * height;
            return area;
        }
    }

    public class Boxes
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var listOfBoxes = new List<Box>();

            while (entry != "end")
            {
                var currentBox = ReadBox(entry);
                listOfBoxes.Add(currentBox);

                entry = Console.ReadLine();
            }

            foreach (var box in listOfBoxes)
            {
                var width = Point.CalculateDistance(box.UpperLeft, box.UpperRight);
                var height = Point.CalculateDistance(box.UpperLeft, box.BottomLeft);
                Console.WriteLine($"Box: {width}, {height}");
                var perimeter = Box.CalculatePerimeter(width, height);
                Console.WriteLine($"Perimeter: {perimeter}");
                var area = Box.CalculateArea(width, height);
                Console.WriteLine($"Area: {area}");
            }
        }

        public static Box ReadBox(string entry)
        {
            var boxParams = entry.Split(new[] {'|', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            var boxPoints = new List<Point>();

            for (int i = 0; i < boxParams.Length; i++)
            {
                var currentPoint = ReadPoint(boxParams[i].Split(':'));
                boxPoints.Add(currentPoint);
            }

            var currentBox = new Box
            {
                UpperLeft = boxPoints[0],
                UpperRight = boxPoints[1],
                BottomLeft = boxPoints[2],
                BottomRight = boxPoints[3]
            };

            return currentBox;
        }

        public static Point ReadPoint(string[] point)
        {
            var currentPoint = new Point
            {
                X = int.Parse(point[0]),
                Y = int.Parse(point[1])
            };

            return currentPoint;
        }
    }
}
