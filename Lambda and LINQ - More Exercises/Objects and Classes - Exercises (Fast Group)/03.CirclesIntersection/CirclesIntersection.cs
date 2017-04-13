namespace _03.CirclesIntersection
{
    using System;
    using System.Linq;

    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; } 
        public int Radius { get; set; }

        public static Circle Parse(string circleParamsAsString)
        {
            var circleParams = circleParamsAsString.Split(' ').Select(int.Parse).ToArray();

            return new Circle
            {
                X = circleParams[0],
                Y = circleParams[1],
                Radius = circleParams[2]
            };
        }

        public bool Intersect(Circle circle)
        {
            var distance = Math.Sqrt(Math.Pow(circle.X - X,2) + Math.Pow(circle.Y + Y,2));

            if (distance <= Radius + circle.Radius)
            {
                return true;
            }
            else return false;
        }
    }

    public class CirclesIntersection
    {
        public static void Main()
        {
            var firstCircle = Circle.Parse(Console.ReadLine());
            var secondCircle = Circle.Parse(Console.ReadLine());

            var result = firstCircle.Intersect(secondCircle)?"Yes":"No";

            Console.WriteLine(result);
        }
    }
}
