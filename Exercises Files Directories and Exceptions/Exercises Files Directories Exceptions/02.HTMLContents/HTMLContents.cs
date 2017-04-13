namespace _02.HTMLContents
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class HTMLContents
    {
        public static void Main()
        {
            File.Delete("index.html");

            var inputLine = Console.ReadLine();

            var indexContent = new Dictionary<string, List<string>>();

            while (inputLine != "exit")
            {
                var inputParams = inputLine.Split(' ');

                var tag = inputParams[0];
                var content = inputParams[1];

                if (tag == "title")
                {
                    indexContent[tag] = new List<string>();
                    indexContent[tag].Add(content);
                }
                else
                {
                    if (!indexContent.ContainsKey(tag))
                    {
                        indexContent[tag] = new List<string>();
                    }
                    indexContent[tag].Add(content);
                }
               
                inputLine = Console.ReadLine();
            }
            File.AppendAllText("index.html", "<!DOCTYPE html>" + Environment.NewLine);
            File.AppendAllText("index.html", "<html>" + Environment.NewLine);
            File.AppendAllText("index.html", "<head>" + Environment.NewLine);
            if (indexContent.ContainsKey("title"))
            {
                File.AppendAllText("index.html", "\t" + "<title>" + string.Join(" ",indexContent["title"]) + $"</title>" + Environment.NewLine);
            }
            File.AppendAllText("index.html", "</head>" + Environment.NewLine);
            File.AppendAllText("index.html", "<body>" + Environment.NewLine);
            foreach (var kvp in indexContent.Where(x=>x.Key!= "title"))
            {
                var tag = kvp.Key;
                var content = kvp.Value;
                foreach (var entry in content)
                {
                    File.AppendAllText("index.html", "\t" + $"<{tag}>" + entry + $"</{tag}>" + Environment.NewLine);
                }

            }
            File.AppendAllText("index.html", "</body>" + Environment.NewLine);
            File.AppendAllText("index.html", "<html>" + Environment.NewLine);
        }
    }
}
