namespace _01.SerializeString
{
    using System;
    using System.Linq;
    using System.Text;

    public class SerializeString
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var resultAsString = new StringBuilder();
            var output = string.Empty;

            foreach (var symbol in inputLine)
            {
                var result = new StringBuilder();

                if (!output.Contains(symbol))
                {
                    result.Append(symbol+":");
                    var charIndex = -1;
                    while (true)
                    {
                        charIndex = inputLine.IndexOf(symbol, charIndex + 1);
                        if (charIndex < 0) break;
                        result.Append(charIndex +"/");
                    }
                }
                else continue;
                resultAsString.AppendLine(result.ToString().Remove(result.Length-1));
                output = resultAsString.ToString().Remove(resultAsString.Length-1);
            }


            Console.WriteLine(output);
        }
    }
}
