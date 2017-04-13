namespace _06.RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Bottom
        {
            get { return Top + Height; }
        }

        public int Right
        {
            get { return Left + Width; }
        }

        public bool IsInside(Rectangle rectangle)
        {
            var leftIsValid = rectangle.Left <= Left;
            var topIsValid = rectangle.Top <= Top;
            var rightIsValid = rectangle.Right >= Right;
            var bottomIsValid = rectangle.Bottom >= Bottom;

            return leftIsValid && topIsValid && rightIsValid && bottomIsValid;
        }
    }

    public class RectanglePosition
    {
        public static void Main()
        {
            var firstRectangle = ReadRectangle();
            var secondRectangle = ReadRectangle();

            var result = firstRectangle.IsInside(secondRectangle)?"Inside":"Not inside";

            Console.WriteLine(result);
        }

        public static Rectangle ReadRectangle()
        {
            var points = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var rectangle = new Rectangle()
            {
                Left = points[0],
                Top = points[1],
                Width = points[2],
                Height = points[3]
            };

            return rectangle;
        }
    }
}
