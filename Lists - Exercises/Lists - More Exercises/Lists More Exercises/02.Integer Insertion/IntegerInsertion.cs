namespace _02.Integer_Insertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                int index = input[0] - '0';
                int numberToInsert = int.Parse(input);
                listOfNumbers.Insert(index,numberToInsert);
                

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",listOfNumbers));



        }
    }
}
