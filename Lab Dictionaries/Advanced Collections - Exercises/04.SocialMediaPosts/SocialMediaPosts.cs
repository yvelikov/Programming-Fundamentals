namespace _04.SocialMediaPosts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SocialMediaPosts
    {
        public static void Main()
        {
            var entry = Console.ReadLine().Split();

            var likes = new Dictionary<string, int[]>();
            var comments = new Dictionary<string, Dictionary<string,string>>();

            while (entry[0] != "drop")
            {
                var command = entry[0];
                string postName = string.Empty;
                switch (command)
                {
                    case "post":
                        postName = entry[1];
                        if (!likes.ContainsKey(postName))
                        {
                            likes[postName] = new int[2];
                        }
                        break;
                    case "like":
                        postName = entry[1];
                        likes[postName][0]++;
                        break;
                    case "dislike":
                        postName = entry[1];
                        likes[postName][1]++;
                        break;
                    case "comment":
                        postName = entry[1];
                        var commentatorName = entry[2];
                        string content = string.Empty;
                        //var content = entry[3];

                        for (int i = 3; i < entry.Length; i++)
                        {
                            content += entry[i] + " ";
                        }
                        

                        if (!comments.ContainsKey(postName))
                        {
                            comments[postName] = new Dictionary<string, string>();
                        }
                        if (!comments[postName].ContainsKey(commentatorName))
                        {
                            comments[postName][commentatorName] = content;
                        }
                        comments[postName][commentatorName] = content;
                        break;
                }

                entry = Console.ReadLine().Split();
            }

            foreach (var like in likes)
            {
                Console.WriteLine($"Post: {like.Key} | Likes: {like.Value[0]} | Dislikes: {like.Value[1]}");
                Console.WriteLine("Comments:");
                if (!comments.ContainsKey(like.Key))
                {
                    Console.WriteLine("None");
                }
                else
                {
                    foreach (var comment in comments)
                    {
                        if (comment.Key == like.Key)
                        {
                            foreach (var comentator in comment.Value)
                            Console.WriteLine($"*  {comentator.Key}: {comentator.Value}");
                        }
                    }
                }
            }
            

        }
    }
}
