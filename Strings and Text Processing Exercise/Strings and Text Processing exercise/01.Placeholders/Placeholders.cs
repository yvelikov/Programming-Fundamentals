namespace _01.Placeholders
{
    using System;
    using System.Text;

    public class Placeholders
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputParams = inputLine.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                var sentence = inputParams[0].Trim();
                var placeholders = inputParams[1].Split(new[] { ','}, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < placeholders.Length; i++)
                {
                    placeholders[i] = placeholders[i].Trim();
                }

                for (int i = 0; i < placeholders.Length; i++)
                {
                    sentence = sentence.Replace($"{{{i}}}", placeholders[i]);
                }

                Console.WriteLine(sentence);

                inputLine = Console.ReadLine();
            }
        }
    }
}
