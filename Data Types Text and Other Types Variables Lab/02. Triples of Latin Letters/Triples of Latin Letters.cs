


namespace _02.Triples_of_Latin_Letters
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number ; i++)
                for (int j = 0; j < number ; j++)
                    for (int k = 0; k < number ; k++)
                    {
                        char firstLetter = (char)('a' + i);
                        char secondLetter = (char)('a' + j);
                        char thirdLetter = (char)('a' + k);
                        Console.WriteLine($"{firstLetter}{secondLetter}{thirdLetter}");


                    }
        }
    }
}
