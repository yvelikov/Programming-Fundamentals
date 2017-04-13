namespace _01.FilterExtensions
{
    using System;
    using System.Linq;
    using System.IO;

    public class FilterExtensions
    {
        public static void Main()
        {
            var filesToRead = Directory.GetFiles("input");

            var extension = Console.ReadLine();

            foreach (var file in filesToRead)
            {
                var currentExtension = file.Split('.').Reverse().ToArray();

                var fileInfo = new FileInfo(file);

                if (currentExtension[0] == extension)
                {
                    Console.WriteLine(fileInfo.Name);
                }
            }
        }
    }
}
