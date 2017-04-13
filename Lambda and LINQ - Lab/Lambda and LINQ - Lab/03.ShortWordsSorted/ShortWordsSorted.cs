namespace _03.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var words = Console.ReadLine()
                .ToLower()
                .Split(new[] { '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(w => w)
                .Where(w => w.Length < 5)
                .Distinct();
                

            Console.WriteLine(string.Join(", ",words));
        }
    }
}
