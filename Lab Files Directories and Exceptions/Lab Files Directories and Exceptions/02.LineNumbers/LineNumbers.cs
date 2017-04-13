namespace _02.LineNumbers
{
    using System;
    using System.IO;
    public class LineNumbers
    {
        public static void Main()
        {
            var text = File.ReadAllLines("input.txt");

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText("output.txt", i+1 +"." + " " + text[i] + Environment.NewLine);
            }
        }
    }
}
