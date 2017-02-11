using System;

namespace MiningCoins_Broken
{
    class MiningCoins
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            string decrypted = string.Empty;
            float totalValue = 0.0f;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                int firstDigit = number / 100;
                int secondDigit = (number / 10) % 10;
                int thirdDigit = number % 10;

                totalValue += (firstDigit + secondDigit + thirdDigit) / (float)n;
                int code = 0;

                if (i % 2 == 0)
                {
                    code = (firstDigit*10 + thirdDigit) + secondDigit;
                    
                }
                else
                {
                    code = (firstDigit*10 + thirdDigit) - secondDigit;
                }

                if ((code >= 65 && code <= 90) || (code >= 97 && code <= 122))
                {
                    decrypted += (char)code;
                }
            }


            Console.WriteLine("Message: {0}", decrypted);
            Console.WriteLine("Value: {0:F7}", totalValue);
        }
    }
}
