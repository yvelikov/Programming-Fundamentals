using System;

class Notifications
{
    public static void Main()
    {
        var n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var result = Console.ReadLine();

            if (result == "success")
            {
                var operation = Console.ReadLine();
                var message = Console.ReadLine();

                PrintSuccess(operation, message);
            }
            else if (result == "error")
            {
                var operation = Console.ReadLine();
                var code = int.Parse(Console.ReadLine());

                PrintError(operation, code);
            }
        }
    }

    public static void PrintSuccess(string operation, string message)
    {
        var result = $"Successfully executed {operation}." + Environment.NewLine;
        result += "==============================" + Environment.NewLine;
        result += $"Message: {message}.";

        Console.WriteLine(result);
    }

    public static void PrintError(string operation, int code)
    {
        var result = $"Error: Failed to execute {operation}." + Environment.NewLine;
        result += "==============================" + Environment.NewLine;
        result += $"Error Code: {code}." + Environment.NewLine;

        var reason = string.Empty;
        if (code > 0)
        {
            reason = "Invalid Client Data";
        }
        else
        {
            reason = "Internal System Failure";
        }

        result += $"Reason: {reason}.";

        Console.WriteLine(result);
    }
}