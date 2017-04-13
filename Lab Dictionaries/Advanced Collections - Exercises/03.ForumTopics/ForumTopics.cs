namespace _03.ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForumTopics
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split('-', '>');

            var taggedForumTopics = new Dictionary<string, HashSet<string>>();

            while (entry[0] != "filter")
            {
                var topic = entry[0].Trim(' ');
                var tags = entry[2].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!taggedForumTopics.ContainsKey(topic))
                {
                    taggedForumTopics[topic] = new HashSet<string>();
                }
                foreach (var tag in tags)
                {
                    taggedForumTopics[topic].Add(tag);
                }

                entry = Console.ReadLine().Split('-', '>');
            }

            var sequenceOfTags = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);



            foreach (var topic in taggedForumTopics)
            {
                var count = 0;
                for (int i = 0; i < sequenceOfTags.Length; i++)
                {
                    if (topic.Value.Contains(sequenceOfTags[i]))
                    {
                        count++;
                    }
                }

                if (count == sequenceOfTags.Length)
                {
                    var tagsToPrint = new List<string>();
                    foreach (var tagToPrint in topic.Value)
                    {
                        tagsToPrint.Add("#" + tagToPrint);
                    }
                    Console.WriteLine($"{topic.Key} | {string.Join(", ", tagsToPrint)}");
                }
            }
        }
    }
}
