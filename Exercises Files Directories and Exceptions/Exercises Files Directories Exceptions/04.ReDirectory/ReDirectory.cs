namespace _04.ReDirectory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class ReDirectory
    {
        public static void Main()
        {
            var selectedFiles = Directory.GetFiles("input");

            var sortedFiles = new Dictionary<string, List<FileInfo>>();

            foreach (var file in selectedFiles)
            {
                var currentFile = new FileInfo(file);
                var currentExtension = file.Split('.').Reverse().First();

                if (!sortedFiles.ContainsKey(currentExtension))
                {
                    sortedFiles[currentExtension] = new List<FileInfo>();
                }
                sortedFiles[currentExtension].Add(currentFile);
            }

            Directory.CreateDirectory("output");

            foreach (var extension in sortedFiles)
            {
                Directory.CreateDirectory($"output/{extension.Key + "s"}/");
                foreach (var file in extension.Value)
                {
                    Console.WriteLine($"{file}" + " " + $"output/{extension.Key + "s"}/");
                    Directory.Move($"{file}",$"output/{extension.Key + "s"}/");
                }
            }
        }
    }
}
