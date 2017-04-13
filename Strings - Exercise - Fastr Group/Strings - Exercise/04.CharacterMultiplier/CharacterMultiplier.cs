namespace _04.CharacterMultiplier
{
    using System;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ');

            var firstString = inputLine[0];
            var secondString = inputLine[1];

            int sum = 0;
            int maxLength = Math.Max(firstString.Length, secondString.Length);
            int minlengh = Math.Min(firstString.Length, secondString.Length);

            for (int i = 0; i < minlengh; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            if (maxLength == firstString.Length)
            {
                for (int i = minlengh; i < maxLength; i++)
                {
                    sum += firstString[i];
                }
            }

            else if (maxLength == secondString.Length)
            {
                for (int i = minlengh; i < maxLength; i++)
                {
                    sum += secondString[i];
                }
            }
          
            Console.WriteLine(sum);
        }
    }
}
