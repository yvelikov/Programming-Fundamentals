namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    public class Snake
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    public class Animals
    {
        public static void Main()
        {
            var command = Console.ReadLine();

            var listOfDogs = new List<Dog>();
            var listOfCats = new List<Cat>();
            var listOfSnakes = new List<Snake>();

            while (command != "I'm your Huckleberry")
            {
                var commandParams = command.Split(' ').ToArray();

                if (commandParams[0] == "talk")
                {
                    var name = commandParams[1];
                    foreach (var dog in listOfDogs)
                    {
                        if (name == dog.Name) dog.ProduceSound();
                    }

                    foreach (var cat in listOfCats)
                    {
                        if (name == cat.Name) cat.ProduceSound();
                    }

                    foreach (var snake in listOfSnakes)
                    {
                        if (name == snake.Name) snake.ProduceSound();
                    }
                }
                else if (commandParams[0] == "Dog")
                {
                    var currentDog = ReadDog(commandParams);
                    listOfDogs.Add(currentDog);
                }
                else if (commandParams[0] == "Cat")
                {
                    var currentCat = ReadCat(commandParams);
                    listOfCats.Add(currentCat);
                }
                else if (commandParams[0] == "Snake")
                {
                    var currentSnake = ReadSnake(commandParams);
                    listOfSnakes.Add(currentSnake);
                }

                command = Console.ReadLine();
            }

            foreach (var dog in listOfDogs)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in listOfCats)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }
            foreach (var snake in listOfSnakes)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }

        }

        public static Snake ReadSnake(string [] commandParams)
        {
            return new Snake
            {
                Name = commandParams[1],
                Age = int.Parse(commandParams[2]),
                CrueltyCoefficient = int.Parse(commandParams[3])
            };
        }

        public static Cat ReadCat(string[] commandParams)
        {
            return new Cat
            {
                Name = commandParams[1],
                Age = int.Parse(commandParams[2]),
                IntelligenceQuotient = int.Parse(commandParams[3])
            };
        }

        public static Dog ReadDog(string[] commandParams)
        {
            return new Dog
            {
                Name = commandParams[1],
                Age = int.Parse(commandParams[2]),
                NumberOfLegs = int.Parse(commandParams[3])
            };
        }
    }
}
