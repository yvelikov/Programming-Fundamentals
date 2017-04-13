using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.FishStatistics
{
    public class Fish
    {
        public string Shape { get; set; }
        public int TailLength { get; set; }
        public int BodyLength { get; set; }
        public string Status { get; set; }
    }
    public class FishStatistics
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var pattern = @"(>*)<([\(]+)(['\-x])>";
            var regex = new Regex(pattern);

            var seaOfFish = new List<Fish>();
            var matches = regex.Matches(inputLine);

            foreach (Match match in matches)
            {
                var currentFish = new Fish();
                currentFish.Shape = match.Groups[0].ToString();
                currentFish.TailLength = match.Groups[1].ToString().Length;
                currentFish.BodyLength = match.Groups[2].ToString().Length;
                currentFish.Status = match.Groups[3].ToString();
                seaOfFish.Add(currentFish);
            }

            if (seaOfFish.Count > 0)
            {
                var count = 1;
                foreach (var fish in seaOfFish)
                {
                    Console.WriteLine($"Fish {count}: {fish.Shape}");
                    PrintTailType(fish);
                    PrintBodyType(fish);
                    PrintStatus(fish);
                    count++;
                }
            }
            else Console.WriteLine("No fish found.");
        }

        public static void PrintStatus(Fish fish)
        {
            var status = string.Empty;

            if (fish.Status == "'")
            {
                status = "Awake";
            }
            else if (fish.Status == "-")
            {
                status = "Asleep";
            }
            else if (fish.Status == "x")
            {
                status = "Dead";
            }
            Console.WriteLine($"Status: {status}");
        }

        public static void PrintBodyType(Fish fish)
        {
            var bodyType = string.Empty;
            if (fish.BodyLength < 6)
            {
                bodyType = "Short";
            }
            else if (fish.BodyLength < 11)
            {
                bodyType = "Medium";
            }
            else bodyType = "Long";
            Console.WriteLine($"\tBody type: {bodyType} ({fish.BodyLength * 2} cm)");
        }

        public static void PrintTailType(Fish fish)
        {
            var tailType = string.Empty;
            if (fish.TailLength == 0)
            {
                tailType = "None";
            }
            else if (fish.TailLength == 1)
            {
                tailType = "Short";
            }
            else if (fish.TailLength < 6)
            {
                tailType = "Medium";
            }
            else tailType = "Long";
            
            if (tailType != "None")
            {
                Console.WriteLine($"\tTail type: {tailType} ({fish.TailLength*2} cm)");
            }
            else Console.WriteLine($"\tTail type: {tailType}");
        }
    }
}
