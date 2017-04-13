namespace _09.Altitude
{
    using System;
    public class Altitude
    {
        public static void Main()
        {
            string[] commandSequence = Console.ReadLine().Split(' ');
            long altitude = long.Parse(commandSequence[0]);

            for (int i = 1; i < commandSequence.Length; i++)
            {
                if (altitude > 0)
                {
                    if (i % 2 != 0)
                    {
                        if (commandSequence[i] == "up")
                        {
                            altitude += long.Parse(commandSequence[i + 1]);
                        }
                        else if (commandSequence[i] == "down")
                        {
                            altitude -= long.Parse(commandSequence[i + 1]);
                            if (altitude <= 0)
                            { 
                                break;
                            }
                        }

                    }
                }


            }
            if (altitude > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            else
                Console.WriteLine("crashed");
        }
    }
}