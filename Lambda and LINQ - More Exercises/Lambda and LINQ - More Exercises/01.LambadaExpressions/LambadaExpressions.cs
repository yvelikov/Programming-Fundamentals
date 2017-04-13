namespace _01.LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var lambadaExpressions = new Dictionary<string, Dictionary<string, string>>();

            while (entry != "lambada")
            {
                if (entry != "dance")
                {
                    var lambdaParams = entry.Split(new[] { ' ', '=', '>', '.' }, StringSplitOptions.RemoveEmptyEntries);
                    var selector = lambdaParams[0];
                    var selectorObject = lambdaParams[1];
                    var property = lambdaParams[2];

                    if (!lambadaExpressions.ContainsKey(selector))
                    {
                        lambadaExpressions[selector] = new Dictionary<string, string>();
                    }
                    lambadaExpressions[selector][selectorObject] = property;

                }
                else
                {
                    lambadaExpressions = lambadaExpressions
                        .ToDictionary(x => x.Key, x => x.Value.ToDictionary(y => y.Key, y => y.Key +'.'+y.Value));
                }

                entry = Console.ReadLine();
            }

            foreach (var selector in lambadaExpressions)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.Write($"{selector.Key} => ");
                    Console.WriteLine($"{selectorObject.Key}.{selectorObject.Value}");
                }
            }
        }
    }
}
