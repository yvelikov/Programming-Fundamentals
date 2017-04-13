namespace _05.DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            string[] frequencies = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var result = new List<int>();

            for (int i = 0; i < frequencies.Length; i++)
            {
                var freq = frequencies[i].Split('.');
                if (i == 0)
                {
                    for (int j = 0; j < freq.Length; j++)
                    {
                        result.Add(int.Parse(freq[j]));
                    }
                }
                else
                {
                    for (int j = 0; j < freq.Length; j++)
                    {
                        if (freq[j] != "0")
                        {
                            result.Insert(j + i, int.Parse(freq[j]));
                        }
                    }
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write((char)result[i]);
            }
            Console.WriteLine();
        }
    }
}
