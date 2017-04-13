namespace _02.TrackDownloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrackDownloader
    {
        public static void Main()
        {
            var blackList = Console.ReadLine()
                .Split(' ')
                .ToList();

            var fileName = Console.ReadLine();

            var result = new List<string>();

            while (fileName != "end")
            {
                bool toIgnore = false;

                for (int i = 0; i < blackList.Count; i++)
                {
                    if (fileName.Contains(blackList[i]))
                    {
                        toIgnore = true;
                    }
                }

                if (!toIgnore)
                {
                    result.Add(fileName);
                }
                
                    
                fileName = Console.ReadLine();
            }

            result.Sort();
                      

            Console.WriteLine(string.Join("\n",result));
            
        
        }
    }
}
