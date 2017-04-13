namespace Nilapdromes3
{
    using System;
    using System.Linq;

    public class Nilapdromes3
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var borderFirst = input.Substring(0, input.Length / 2);
                var borderSecond = string.Empty;
                var border = string.Empty;

                if (input.Length % 2 == 0)
                {
                    borderSecond = input.Substring(borderFirst.Length);
                }
                else
                {
                    borderSecond = input.Substring(borderFirst.Length + 1);
                }

                while (true)
                {
                    if (borderFirst == borderSecond)
                    {
                        border = borderFirst;
                        break;
                    }
                    else if (borderFirst != borderSecond)
                    {
                        borderFirst = borderFirst.Substring(0, borderFirst.Length - 1);
                        borderSecond = borderSecond.Substring(1, borderSecond.Length - 1);
                    }

                    if (borderFirst.Length == 0 && borderSecond.Length == 0)
                    {
                        break;
                    }
                }

                if (border.Length != 0)
                {
                    var core = input.Remove(input.Length - border.Length, border.Length).Trim();
                    core = core.Remove(0, border.Length).Trim();
                    if (core != "")
                    {
                        var nilapdromes = core + border + core;
                        Console.WriteLine(nilapdromes);
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
