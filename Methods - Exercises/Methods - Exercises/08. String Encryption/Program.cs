using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.String_Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string encryptedString = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                string encryptedLetter = Encrypt(letter);
                encryptedString += encryptedLetter;

            }

            Console.WriteLine(encryptedString);

        }
        static string Encrypt(char letter)
        {
            string encryptedLetter = string.Empty;
            int code = letter;
            int lastDigit = code % 10;
            int firstDigit = code;
            while (firstDigit >= 10)
            {
                firstDigit /= 10;
            }
            char firstEncryptedLetter = (char)(code + lastDigit);
            char lastEncryptedLetter = (char)(code - firstDigit);
            encryptedLetter = firstEncryptedLetter + firstDigit.ToString() + lastDigit.ToString() + lastEncryptedLetter;
           
                
                
          
            return encryptedLetter ;
        }
    }
}
