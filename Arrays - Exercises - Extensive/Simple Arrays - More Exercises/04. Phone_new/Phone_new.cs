using System;
namespace _04.Phone_new
{
    public class Phone_new
    {
        public static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            int sum = 0;
            int difference = 0;
            string[] command = Console.ReadLine().Split(' ');

            while (command[0] != "done")
            {
                if (command[0] == "call")
                {
                    int totalDuration = Call(phoneNumbers, names, sum, command);
                    if (totalDuration % 2 == 0)
                    {
                        int durationInMinutes = totalDuration / 60;
                        int durationInSeconds = totalDuration % 60;
                        Console.WriteLine("call ended. duration: {0:00}:{1:00}", durationInMinutes, durationInSeconds);
                    }
                    else
                    {
                        Console.WriteLine("no answer");
                    }
                }
                else if (command[0] == "message")
                {
                    difference = Message(phoneNumbers, names, difference, command);
                    if (difference % 2 == 0)
                    {
                        Console.WriteLine("meet me there");
                    }
                    else
                    {
                        Console.WriteLine("busy");
                    }

                }
                command = Console.ReadLine().Split(' ');

            }

        }

        private static int Message(string[] phoneNumbers, string[] names, int difference, string[] command)
        {
            
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (command[1] == phoneNumbers[i])
                {
                    string currentPhoneNumber = phoneNumbers[i];
                    Console.WriteLine($"sending sms to {names[i]}...");
                    difference = GetDifference(currentPhoneNumber);
                    //Console.WriteLine(sum);
                }
                else if (command[1] == names[i])
                {
                    string currentPhoneNumber = phoneNumbers[i];
                    Console.WriteLine($"sending sms to {phoneNumbers[i]}...");
                    difference = GetDifference(currentPhoneNumber);
                }

            }

            return difference;
        }

        

        static int Call(string[] phoneNumbers, string[] names, int sum, string[] command)
        {
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                if (command[1] == phoneNumbers[i])
                {
                    string currenPhoneNumber = phoneNumbers[i];
                    Console.WriteLine($"calling {names[i]}...");
                    sum = GetSum(currenPhoneNumber);
                    //Console.WriteLine(sum);
                }
                else if (command[1] == names[i])
                {
                    string currenPhoneNumber = phoneNumbers[i];
                    Console.WriteLine($"calling {phoneNumbers[i]}...");
                    sum = GetSum(currenPhoneNumber);
                }

            }

            return sum;
        }

        static int GetDifference(string currentPhoneNumber)
        {
            int difference = 0;
            for (int j = 0; j < currentPhoneNumber.Length; j++)
            {
                switch (currentPhoneNumber[j])
                {
                    case '0':
                        difference -= 0;
                        break;
                    case '1':
                        difference -= 1;
                        break;
                    case '2':
                        difference -= 2;
                        break;
                    case '3':
                        difference -= 3;
                        break;
                    case '4':
                        difference -= 4;
                        break;
                    case '5':
                        difference -= 5;
                        break;
                    case '6':
                        difference -= 6;
                        break;
                    case '7':
                        difference -= 7;
                        break;
                    case '8':
                        difference -= 8;
                        break;
                    case '9':
                        difference -= 9;
                        break;
                }
            }
            return difference;
        }

        static int GetSum(string currentPhoneNumber)
        {
            int sum = 0;
            for (int j = 0; j < currentPhoneNumber.Length; j++)
            {
                switch (currentPhoneNumber[j])
                    {
                        case '0':
                            sum += 0;
                            break;
                        case '1':
                            sum += 1;
                            break;
                        case '2':
                            sum += 2;
                            break;
                        case '3':
                            sum += 3;
                            break;
                        case '4':
                            sum += 4;
                            break;
                        case '5':
                            sum += 5;
                            break;
                        case '6':
                            sum += 6;
                            break;
                        case '7':
                            sum += 7;
                            break;
                        case '8':
                            sum += 8;
                            break;
                        case '9':
                            sum += 9;
                            break;
                    }
                }
            return sum;
        }
    }
}
