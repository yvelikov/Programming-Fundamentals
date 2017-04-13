using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.ArrayHistogram
{
    public class ArrayHistogram
    {
        public static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split(' ');

            var words = new List<string>();
            var occurrences = new List<int>();

            for (int i = 0; i < inputString.Length; i++)
            {

                if (words.Contains(inputString[i]))
                {
                    for (int j = 0; j < words.Count; j++)
                    {
                        if (words[j] == inputString[i])
                        {
                            occurrences[j]++;
                        }
                    }
                    
                }
                else
                {
                    words.Add(inputString[i]);
                    occurrences.Add(1);
                    
                } 
            }

            for (int i = 0; i < words.Count - 1; i++)
            {
                var j = i + 1;
                while (j > 0)
                {
                    if (occurrences[j] > occurrences[j - 1])
                    {
                        int currentNumber = occurrences[j];
                        string currentWord = words[j];
                        occurrences[j] = occurrences[j - 1];
                        words[j] = words[j - 1];
                        occurrences[j - 1] = currentNumber;
                        words[j - 1] = currentWord;
                    }
                    j--;
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                Console.WriteLine("{0} -> {1} times ({2:F2}%)", words[i],occurrences[i],100*((occurrences[i])/(double)inputString.Length));
            }
             
        }
    }
}
