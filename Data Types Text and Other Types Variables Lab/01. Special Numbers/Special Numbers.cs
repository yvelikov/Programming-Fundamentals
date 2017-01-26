


namespace Data_Types_Lab
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int maxNumber = int.Parse(Console.ReadLine());
            for (int i = 1; i <= maxNumber; i++)
            {
                int currentNumber = i;
                int sum = 0;
                int lastDigit = 0;
                while (currentNumber > 0)
                {
                    lastDigit = currentNumber % 10;
                    currentNumber /= 10;
                    sum += lastDigit;
                    
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} ->{isSpecial}");
            }
        }
    }
}
