namespace _02.DictRefAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRefAdvanced
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split('-','>',);

            var dictRef = new Dictionary<string, List<int>>();

            while (entry[0] != "end")
            {
                var name = entry[0].Trim();
                var grades = entry[2].Split(new[] {',', ' '},StringSplitOptions.RemoveEmptyEntries);
                int number;
                bool parsed = int.TryParse(grades[0], out number);

                if (parsed)
                {
                    if (!dictRef.ContainsKey(name))
                    {
                        dictRef[name] = new List<int>();
                    }
                    foreach (var grade in grades)
                    {
                        dictRef[name].Add(int.Parse(grade));
                    }
                }
                else
                {
                    if (dictRef.ContainsKey(grades[0]))
                    {
                        if (!dictRef.ContainsKey(name))
                        {
                            dictRef[name] = new List<int>();
                        }

                        foreach (var grade in dictRef[grades[0]])
                        {
                            dictRef[name].Add(grade);
                        }
                    }
                        
                    
                }

                entry = Console.ReadLine().Split('-', '>');
            }

            foreach (var name in dictRef)
            {
                Console.Write($"{name.Key} === ");
                Console.Write(string.Join(", ",name.Value));
                Console.WriteLine();
            }
        }
    }
}
