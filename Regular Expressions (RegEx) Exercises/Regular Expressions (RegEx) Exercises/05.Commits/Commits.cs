namespace _05.Commits
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Commit
    {
        public string Hash { get; set; }
        public string Message { get; set; }
        public decimal Additions { get; set; }
        public decimal Deletions { get; set; }
    }
    public class Commits
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var gitHub = new SortedDictionary<string, SortedDictionary<string, List<Commit>>>();

            var pattern = @"https:\/\/github.com\/([A-Za-z0-9\-]+)\/([A-Za-z\-_]+)\/commit\/((?:\d|[a-f]){40}),(.+?),(\d+),(\d+)";

            var regex = new Regex(pattern);

            while (inputLine != "git push")
            {
                var isMatch = regex.IsMatch(inputLine);

                if (isMatch)
                {
                    var match = regex.Match(inputLine);
                    var username = match.Groups[1].Value;
                    var repo = match.Groups[2].Value;
                    var hash = match.Groups[3].Value;
                    var message = match.Groups[4].Value;
                    var additions = decimal.Parse(match.Groups[5].Value);
                    var deletions = decimal.Parse(match.Groups[6].Value);

                    var currentCommit = new Commit()
                    {
                        Hash = hash,
                        Message = message,
                        Additions = additions,
                        Deletions = deletions
                    };

                    if (!gitHub.ContainsKey(username))
                    {
                        gitHub[username] = new SortedDictionary<string, List<Commit>>();
                    }
                    if (!gitHub[username].ContainsKey(repo))
                    {
                        gitHub[username][repo] = new List<Commit>();
                    }
                    gitHub[username][repo].Add(currentCommit);

                }

                inputLine = Console.ReadLine();
            }

            foreach (var user in gitHub)
            {
                Console.WriteLine(user.Key+":");
                foreach (var repo in user.Value)
                {
                    Console.WriteLine("  "+repo.Key+":");
                    var listOfCommits = repo.Value;
                    var totalAdditions = listOfCommits.Select(x => x.Additions).Sum();
                    var totalDeletions = listOfCommits.Select(x => x.Deletions).Sum();
                    foreach (var commit in repo.Value)
                    {
                        Console.WriteLine($"    commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");
                    }
                    Console.WriteLine($"    Total: {totalAdditions} additions, {totalDeletions} deletions");
                }
            }
        }
    }
}
