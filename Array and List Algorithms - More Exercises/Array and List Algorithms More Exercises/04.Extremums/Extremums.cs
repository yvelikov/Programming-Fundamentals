namespace _04.Extremums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Extremums
    {
        public static void Main()
        {
            var sequence = Console.ReadLine()
                .Split(' ')
                .ToList();
            var command = Console.ReadLine();

            switch (command)
            {
                case "Max":
                    var maxSum = 0m;
                    var maxResult = new List<decimal>();
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        var currentNumber = new List<decimal>();
                        var number = sequence[i];

                        for (int j = 0; j < number.Length; j++)
                        {
                            var digit = number[j] - '0';
                            currentNumber.Add(digit);
                        }

                        var max = RotateRight(currentNumber);
                        maxResult.Add(max);
                        maxSum += max;
                    }
                    Console.WriteLine(string.Join(", ",maxResult));
                    Console.WriteLine(maxSum);
                    break;

                case "Min":
                    var minSum = 0m;
                    var minResult = new List<decimal>();
                    for (int i = 0; i < sequence.Count; i++)
                    {
                        var currentNumber = new List<decimal>();
                        var number = sequence[i];

                        for (int j = 0; j < number.Length; j++)
                        {
                            var digit = number[j] - '0';
                            currentNumber.Add(digit);
                        }

                        var min = RotateLeft(currentNumber);

                        minResult.Add(min);
                        minSum += min;
                    }
                    Console.WriteLine(string.Join(", ", minResult));
                    Console.WriteLine(minSum);
                    break;
            }
        }

        private static decimal RotateRight(List<decimal> currentNumber)
        {
            var result = new decimal[currentNumber.Count];
            var max = decimal.MinValue;
            var rotations = currentNumber.Count;
            for (int i = 0; i < rotations; i++)
            {
                var lastElement = currentNumber[currentNumber.Count - 1];

                for (int j = 0; j < currentNumber.Count - 1; j++)
                {
                    result[j + 1] = currentNumber[j];
                }
                result[0] = lastElement;

                for (int j = 0; j < result.Length; j++)
                {
                    currentNumber[j] = result[j];
                }

                var currenNumber = decimal.Parse(string.Join("",result));

                if (currenNumber > max)
                {
                    max = currenNumber;
                }

            }
            

            return max;
        }

        private static decimal RotateLeft(List<decimal> currentNumber)
        {
            var result = new decimal[currentNumber.Count];
            var min = decimal.MaxValue;
            var rotations = currentNumber.Count;
            for (int i = 0; i < rotations; i++)
            {
                var firstElement = currentNumber[0];

                for (int j = 0; j < currentNumber.Count - 1; j++)
                {
                    result[j] = currentNumber[j + 1];
                }
                result[result.Length - 1] = firstElement;
                for (int j = 0; j < result.Length; j++)
                {
                    currentNumber[j] = result[j];
                }

                var currenNumber = decimal.Parse(string.Join("", result));

                if (currenNumber < min)
                {
                    min = currenNumber;
                }
            }

            return min;
        }
    }
}
