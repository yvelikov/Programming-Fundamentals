namespace _04.MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MergeFiles
    {
        public static void Main()
        {
            var firstInput = File.ReadAllLines("FileOne.txt");
            var secondInput = File.ReadAllLines("FileTwo.txt");

            var result = new List<int>();

            for (int i = 0; i < Math.Max(firstInput.Length, secondInput.Length); i++)
            {
                if (i < firstInput.Length)
                {
                    result.Add(int.Parse(firstInput[i]));
                }
                if (i < secondInput.Length)
                {
                    result.Add(int.Parse(secondInput[i]));
                }
            }

            result = result.OrderBy(x => x).ToList();

            foreach (var number in result)
            {
                File.AppendAllText("output.txt", number + Environment.NewLine);
            }
        }
    }
}
