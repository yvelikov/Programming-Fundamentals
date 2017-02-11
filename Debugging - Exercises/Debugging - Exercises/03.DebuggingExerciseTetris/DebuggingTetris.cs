using System;

namespace Tetris_Broken
{
    class Debuggingtetris
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string currentDirection = Console.ReadLine();

            while (currentDirection != "exit")
            {
                switch (currentDirection)
                {
                    case "up":
                        RotateUp(n);
                        break;
                    case "right":
                        RotateRight(n);
                        break;
                    case "down":
                        RotateDown(n);
                        break;
                    case "left":
                        RotateLeft(n);
                        break;
                }

                currentDirection = Console.ReadLine();
            }
        }

        static void RotateLeft(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('.', n)
                    + new string('*', n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('.', n)
                    + new string('*', n));
            }
        }

        static void RotateRight(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', n)
                    + new string('.', n)
                    );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', 2 * n));
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                    new string('*', n)
                    + new string('.', n)
                    );
            }
        }

        static void RotateUp(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('.', n)
                        + new string('*', n)
                        + new string('.', n)
                        );
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('*', n * 3)
                        );
            }
        }

        static void RotateDown(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('*', n * 3)
                        );
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(
                        new string('.', n)
                        + new string('*', n)
                        + new string('.', n)
                        );
            }
        }
    }
}
