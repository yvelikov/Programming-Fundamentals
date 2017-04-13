namespace _07.SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public static Sale ParseSale(string stringAsSale)
        {
            var saleParams = stringAsSale.Split(' ');

            return new Sale
            {
                Town = saleParams[0],
                Product = saleParams[1],
                Price = decimal.Parse(saleParams[2]),
                Quantity = decimal.Parse(saleParams[3])
            };
        }
    }

    public class SalesReport
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var salesByTown = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentSale = Sale.ParseSale(Console.ReadLine());

                if (!salesByTown.ContainsKey(currentSale.Town))
                {
                    salesByTown[currentSale.Town] = 0;
                }

                salesByTown[currentSale.Town] += currentSale.Price * currentSale.Quantity;
            }

            foreach (var kvp in salesByTown)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }

        }
    }
}
