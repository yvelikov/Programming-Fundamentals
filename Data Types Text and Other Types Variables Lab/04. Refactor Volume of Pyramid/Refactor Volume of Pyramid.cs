﻿


namespace _04.Refactor_Volume_of_Pyramid
{
    using System;
    public class Program
    {
        public static void Main()

        {
            double lenght, width, height = 0;

            Console.Write("Length: ");

            lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");

            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");

            height = double.Parse(Console.ReadLine());

            double volume = (lenght * width * height) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
