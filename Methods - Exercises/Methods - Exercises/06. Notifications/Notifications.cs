using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Notifications
{
    class Notifications
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string successOperation = string.Empty;
            string errorOperation = string.Empty;
            string message = string.Empty;
            int code = 1;
            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();
                switch (result)
                {
                    case "success":
                        successOperation = Console.ReadLine();
                        message = Console.ReadLine();
                        ShowSuccess(successOperation, message);
                        break;
                    case "error":
                        errorOperation = Console.ReadLine();
                        code = int.Parse(Console.ReadLine());
                        ShowError(errorOperation, code);
                        break;
                }

            }
           
            


        }

        static void ShowSuccess(string operation, string message)
        {
            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
          

        }
        
        static void ShowError(string operation, int code)
        {
            string reason = string.Empty;
            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            if (code > 0)
            {
                reason = "Invalid Client Data";
            }
            else reason = "Internal System Failure";
            Console.WriteLine($"Reason: {reason}.");
        }

    }
}
