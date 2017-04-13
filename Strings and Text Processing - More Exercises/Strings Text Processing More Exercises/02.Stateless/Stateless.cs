namespace _02.Stateless
{
    using System;
    using System.Text;

    public class Stateless
    {
        public static void Main()
        {
            var state = Console.ReadLine();
            var fiction = Console.ReadLine();

            while (state != "collapse")
            {
                while (fiction.Length > 0 )
                {
                    var fictionIndex = -1;
                    while (true)
                    {
                        fictionIndex = state.IndexOf(fiction, fictionIndex + 1);
                        if (fictionIndex < 0) break;
                        state = state.Remove(fictionIndex, fiction.Length);
                        fictionIndex = -1;
                    }
                    fiction = fiction.Remove(0, 1);
                    if (fiction.Length > 0 )
                    fiction = fiction.Remove(fiction.Length - 1);
                }

                if (state.Length > 0)
                {
                    Console.WriteLine(state.Trim());
                }
                else Console.WriteLine("(void)");

                state = Console.ReadLine();
                fiction = Console.ReadLine();
            }
        }
    }
}
