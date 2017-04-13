namespace _05.FolderSize
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class FolderSize
    {
        public static void Main()
        {
            var files = Directory.GetFiles("TestFolder");

            double sum = 0.0d;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                sum += fileInfo.Length;
            }

            File.AppendAllText("output.txt", (sum / 1024 / 1024).ToString());
        }
    }
}
