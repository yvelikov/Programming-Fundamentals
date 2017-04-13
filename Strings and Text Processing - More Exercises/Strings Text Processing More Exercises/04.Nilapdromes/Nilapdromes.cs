namespace _04.Nilapdromes
{
    using System;

    public class Nilapdromes
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var core = string.Empty;
                var firstBorder = inputLine.Substring(0, inputLine.Length / 2);
                var lastBorder = string.Empty;

                if (inputLine.Length % 2 == 0)
                {
                    lastBorder = inputLine.Substring(firstBorder.Length);
                }
                else
                {
                    lastBorder = inputLine.Substring(firstBorder.Length + 1);
                }

                while (true)
                {
                    if (firstBorder == lastBorder)
                    {
                        break;
                    }
                    else if (firstBorder != lastBorder)
                    {
                        firstBorder = firstBorder.Substring(0,firstBorder.Length-1);
                        lastBorder = lastBorder.Substring(1, lastBorder.Length-1);
                    }
                    if (firstBorder.Length == 0 && firstBorder.Length == 0)
                    {
                        break;
                    }
                }

                if (lastBorder.Length > 0)
                {
                    core = inputLine.Substring(0 + firstBorder.Length, inputLine.Length - lastBorder.Length);
                    core = core.Substring(0, core.Length - lastBorder.Length);
                    if (core.Length >= 1)
                        Console.WriteLine(core + lastBorder + core);
                }

                inputLine = Console.ReadLine();
            }
        }
    }
}
