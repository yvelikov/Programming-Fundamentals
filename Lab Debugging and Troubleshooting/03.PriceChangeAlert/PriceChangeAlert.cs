using System;

class PriceChangeAlert
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double difference = GetDifferenceBetweenLastPriceAndPrice(lastPrice, price);
            bool isSignificantDifference = CheckDifference(difference, threshold);

            string priceChange = GetPriceChange(price, lastPrice, difference, isSignificantDifference);
            Console.WriteLine(priceChange);

            lastPrice = price;
        }
    }

    private static string GetPriceChange(double price, double lastPrice, double difference, bool isSignificantDifference)

    {
        string priceChange = string.Empty;

        if (difference == 0)
        {
            priceChange = string.Format("NO CHANGE: {0}", price);
        }
        else if (!isSignificantDifference)
        {
            priceChange = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, price, difference*100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            priceChange = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, price, difference*100);
        }
        else if (isSignificantDifference && (difference < 0))
            priceChange = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, price, difference*100);

        return priceChange;
    }

    private static bool CheckDifference(double threshold, double isDiff)
    {

        if (Math.Abs(threshold) >= isDiff)
        {
            return true;
        }

        return false;
    }

    private static double GetDifferenceBetweenLastPriceAndPrice(double lastPrice, double price)
    {
        double difference = (price - lastPrice) / lastPrice;
        return difference;
    }
}
