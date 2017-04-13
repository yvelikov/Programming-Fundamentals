namespace _04.Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Website
    {
        public string Host { get; set; }
        public string Domain { get; set; }
        public List<string> Queries {get; set;}
    }

    public class Websites
    {
        public static void Main()
        {
            var entry = Console.ReadLine();

            var listOfWebsites = new List<Website>();

            while (entry != "end")
            {
                var currentWebsite = ReadWebsite(entry);
                listOfWebsites.Add(currentWebsite);

                entry = Console.ReadLine();
            }

            foreach (var website in listOfWebsites)
            {
                Console.Write($"https://www.{website.Host}.{website.Domain}");
                if (website.Queries.Count > 0)
                {
                    Console.WriteLine($"/query?={string.Join("&",website.Queries)}");
                }
            }
        }

        public static Website ReadWebsite(string entry)
        {
            var websiteParams = entry.Split(new[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var currentWebsite = new Website
            {
                Host = websiteParams[0],
                Domain = websiteParams[1],
                Queries = new List<string>()
            };

            for (int i = 2; i < websiteParams.Length; i++)
            {
                var querie = "[" + websiteParams[i] + "]";
                currentWebsite.Queries.Add(querie);
            }

            return currentWebsite;
        }
    }
}
