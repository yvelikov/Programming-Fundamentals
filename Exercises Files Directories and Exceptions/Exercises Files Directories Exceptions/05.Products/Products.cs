namespace _05.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class Products
    {
        public static void Main()
        {
            var stockedProducts = new Dictionary<string, HashSet<Product>>();

            var activeProducts = new Dictionary<string, HashSet<Product>>();

            LoadStock(stockedProducts);

            foreach (var kvp in stockedProducts)
            {
                activeProducts[kvp.Key] = new HashSet<Product>();
                foreach (var product in kvp.Value)
                {
                    activeProducts[kvp.Key].Add(product);
                }
            }

            var stocked = false;

            if (stockedProducts.Count > 0)
            {
                stocked = true;
            }
            
            var inputLine = Console.ReadLine();

            while (inputLine != "exit")
            {
                var inputParams = inputLine.Split(' ');

                if (inputParams[0] == "stock")
                {
                    File.WriteAllLines("stock.txt",activeProducts.Select(x => x.Value).SelectMany(x => x).Select(x=> string.Format($"{x.Name} {x.Type} {x.Price} {x.Quantity}")).ToList());
                    stocked = true;
                }
                else if (inputParams[0] == "analyze")
                {
                    if (stocked)
                    {
                        foreach (var kvp in stockedProducts.OrderBy(x => x.Key))
                        {
                            foreach (var product in kvp.Value)
                            {
                                Console.WriteLine($"{kvp.Key}, Product: {product.Name}");
                                Console.WriteLine($"Price: ${product.Price}, Amount Left: {product.Quantity}");
                            }
                        }
                    }
                    else Console.WriteLine("No products stocked.");
                }
                else if (inputParams[0] == "sales")
                {
                    var incomeByType = new Dictionary<string, decimal>();

                    foreach (var kvp in activeProducts)
                    {
                        var sum = 0.0m;
                        foreach (var product in kvp.Value)
                        {
                            sum += product.Price * product.Quantity;
                        }
                        incomeByType[kvp.Key] = sum;
                    }

                    foreach (var kvp in incomeByType.OrderByDescending(x=>x.Value))
                    {
                        if (kvp.Value > 0)
                        Console.WriteLine($"{kvp.Key}: ${kvp.Value:F2}");
                    }
                }
                else
                {
                    var name = inputParams[0];
                    var type = inputParams[1];
                    var price = decimal.Parse(inputParams[2]);
                    var quantity = int.Parse(inputParams[3]);

                    var currentProdcut = new Product
                    {
                        Name = name,
                        Type = type,
                        Price = price,
                        Quantity = quantity
                    };

                    if (!activeProducts.ContainsKey(currentProdcut.Type))
                    {
                        activeProducts[currentProdcut.Type] = new HashSet<Product>();
                    }

                    bool exists = false;
                    foreach (var kvp in activeProducts)
                    {
                        foreach (var product in kvp.Value)
                        {
                            if (product.Name == name && product.Type == currentProdcut.Type)
                            {
                                product.Price = price;
                                product.Quantity = quantity;
                                exists = true;
                            }
                        }
                    }
                    
                    if (!exists)
                    activeProducts[currentProdcut.Type].Add(currentProdcut);
                }

                inputLine = Console.ReadLine();
            }
        }

        public static void LoadStock(Dictionary<string, HashSet<Product>> stockedProducts)
        {
            if (File.Exists("stock.txt"))
            {
                var products = File.ReadAllLines("stock.txt");

                foreach (var product in products)
                {
                    var currentProductParams = product.Split(' ');
                    var currentProduct = new Product
                    {
                        Name = currentProductParams[0],
                        Type = currentProductParams[1],
                        Price = decimal.Parse(currentProductParams[2]),
                        Quantity = int.Parse(currentProductParams[3])
                    };

                    if (!stockedProducts.ContainsKey(currentProduct.Type))
                    {
                        stockedProducts[currentProduct.Type] = new HashSet<Product>();
                    }
                    stockedProducts[currentProduct.Type].Add(currentProduct);

                }
            }
        }
    }
}
