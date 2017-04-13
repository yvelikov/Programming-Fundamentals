namespace _03.LINQuistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LINQuistics
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var collection = new Dictionary<string,HashSet<string>>();

            while (entry != "exit")
            {
                var collectionParams = entry.Split(new[] { '.', '(', ')' },StringSplitOptions.RemoveEmptyEntries);

                if (collectionParams.Length > 1)
                {
                    var collectionName = collectionParams[0];
                    var methodsList = new HashSet<string>();

                    for (int i = 1; i < collectionParams.Length; i++)
                    {
                        methodsList.Add(collectionParams[i]);
                    }

                    if (!collection.ContainsKey(collectionName))
                    {
                        collection[collectionName] = new HashSet<string>();
                    }

                    foreach (var method in methodsList)
                    {
                        collection[collectionName].Add(method);
                    }
                    
                }
                else
                {
                    int n;
                    bool isParsed = int.TryParse(collectionParams[0], out n);
                    if (isParsed && collection.Count > 0)
                    {
                        var collectionToPrint = collection.Values
                            .OrderByDescending(x => x.Count())
                            .First()
                            .OrderBy(x => x.Length)
                            .Take(n)
                            .ToList();

                        foreach (var method in collectionToPrint)
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                    else
                    {
                        var collectionName = collectionParams[0];
                        if (collection.ContainsKey(collectionName))
                        {
                            var sortedCollection = collection[collectionName]
                                .OrderByDescending(x => x.Length)
                                .ToList();


                            for (int i = 0; i < sortedCollection.Count-1; i++)
                            {
                                if (sortedCollection[i].Length == sortedCollection[i + 1].Length)
                                {
                                    var currentMethod = sortedCollection[i];
                                    int firstCount = sortedCollection[i].Distinct().Count();
                                    int secondCount = sortedCollection[i + 1].Distinct().Count();
                                    if (secondCount > firstCount)
                                    {
                                        sortedCollection[i] = sortedCollection[i + 1];
                                        sortedCollection[i + 1] = currentMethod;
                                    }
                                }
                            }

                            foreach (var method in sortedCollection)
                            {
                                Console.WriteLine($"* {method}");
                            }  
                            
                        }
                    }
                }

                entry = Console.ReadLine();
            }

            var finalCommand = Console.ReadLine().Split();
            var methodToPrint = finalCommand[0];
            var selection = finalCommand[1];

            if (selection == "collection")
            {
                foreach (var col in collection.OrderByDescending(x=>x.Value.Count()).ThenByDescending(x=>x.Value.Min(y=>y.Length)))
                {
                    if (col.Value.Contains(methodToPrint))
                    {
                        Console.WriteLine(col.Key);
                    }
                }
            }
            else
            {
                foreach (var col in collection.OrderByDescending(x => x.Value.Count()).ThenByDescending(x => x.Value.Min(y => y.Length)))
                {
                    if (col.Value.Contains(methodToPrint))
                    {
                        Console.WriteLine(col.Key);
                        foreach (var method in col.Value.OrderByDescending(x=>x.Length))
                        {
                            Console.WriteLine($"* {method}");
                        }
                    }
                }
            }
        }
    }
}
