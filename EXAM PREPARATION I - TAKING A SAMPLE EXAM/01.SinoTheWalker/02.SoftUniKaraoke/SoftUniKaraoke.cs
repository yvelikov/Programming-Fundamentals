namespace _02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries ).ToList();

            var songs = Console.ReadLine().Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var listOfSongs = new List<string>();
            foreach (var song in songs)
            {
                listOfSongs.Add(song.Trim());
            }

            var performers = new Dictionary<string,SortedSet<string>>();

            for (int i = 0; i < participants.Count; i++)
            {
                if (!performers.ContainsKey(participants[i]))
                {
                    performers[participants[i]] = new SortedSet<string>();
                }
            }

            var inputLine = Console.ReadLine();

            while (inputLine != "dawn")
            {
                var inputParams = inputLine.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                var performer = inputParams[0].Trim();
                var song = inputParams[1].Trim();
                var award = inputParams[2].Trim();

                if (participants.Contains(performer) && listOfSongs.Contains(song))
                {
                    performers[performer].Add(award);
                }

                inputLine = Console.ReadLine();
            }

            var result = performers.OrderByDescending(x => x.Value.Count).ThenBy(x=>x.Key).ToList();

            var numberOfAwards = result.Select(x => x.Value.Count).Sum();
            if (numberOfAwards > 0)
            {
                foreach (var performer in result)
                {
                    if (performer.Value.Count > 0)
                    {
                        Console.WriteLine($"{performer.Key}: {performer.Value.Count} awards");
                        foreach (var award in performer.Value)
                        {
                            Console.WriteLine($"--{award}");
                        }
                    }
                    
                }
            }
            else Console.WriteLine("No awards");

        }
    }
}
