namespace _04.Phone
{
    using System;
    public class Phone
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split(' ');
            string[] names = Console.ReadLine().Split(' ');

            int sum = 0;
            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "done")
            {
                if (command[0] == "call")
                {
                    for (int i = 0; i < phoneNumbers.Length; i++)
                    {
                        if (command[1] == phoneNumbers[i])
                        {
                            string currentPhoneNumber = phoneNumbers[i];
                            Console.WriteLine($"calling {names[i]}...");
                            sum = GetSum(currentPhoneNumber);

                            if (sum % 2 == 0)
                            {
                                int totalDurationSeconds = sum;
                                int durationMinutes = sum / 60;
                                int durationSeconds = Math.Abs(sum - 60);
                                Console.WriteLine(sum);
                                Console.WriteLine("call ended. duration {0:00}:{1:00}", durationMinutes, durationSeconds);
                            }
                            else
                                Console.WriteLine("no answer");
                            Console.WriteLine();
                        }
                        else if (command[1] == names[i])
                        {
                            string currentPhoneNumber = phoneNumbers[i];
                            Console.WriteLine($"calling {phoneNumbers[i]}...");
                            sum = GetSum(currentPhoneNumber);

                            if (sum % 2 == 0)
                            {
                                int totalDurationSeconds = sum;
                                int durationMinutes = sum / 60;
                                int durationSeconds = sum - 60;
                                Console.WriteLine(sum);
                                Console.WriteLine("call ended. duration {0:00}:{1:00}", durationMinutes, durationSeconds);
                            }
                            else
                                Console.WriteLine("no answer");
                            Console.WriteLine();

                        }
                    }
                }
                else if (command[0] == "message")
                {
                    //for (int i = 0; i < phoneNumbers.Length; i++)
                    //{
                    //    if (command[1] == phoneNumbers[i])
                    //    {
                    //        string currentPhoneNumber = phoneNumbers[i];
                    //        Console.WriteLine($"calling {names[i]}...");
                    //        sum = GetSum(currentPhoneNumber);

                    //        if (sum % 2 == 0)
                    //        {
                    //            int totalDurationSeconds = sum;
                    //            int durationMinutes = sum / 60;
                    //            int durationSeconds = Math.Abs(sum - 60);
                    //            Console.WriteLine(sum);
                    //            Console.WriteLine("call ended. duration {0:00}:{1:00}", durationMinutes, durationSeconds);
                    //        }
                    //        else
                    //            Console.WriteLine("no answer");
                    //        Console.WriteLine();
                    //    }

                    //}

                }

                command = Console.ReadLine().Split(' ');
            }

            

        }

        static int GetSum(string currentPhoneNumber)
        {
            int sum = 0;
            for (int j = 0; j < currentPhoneNumber.Length; j++)
            {

                if (currentPhoneNumber[j] < 58 && currentPhoneNumber[j] > 47)
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
            }
            return sum;

        }
    }
}


