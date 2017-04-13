namespace _02.RandomizeWords
{
    using System;
    using System.Linq;

    public class RandomizeWords
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            var rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var randomPosition = rnd.Next(0, words.Length);

                var currentWord = words[i];
                words[i] = words[randomPosition];
                words[randomPosition] = currentWord; 

            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            } 
        }
    }
}
