namespace _07.AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string,int> ShopList {get; set;}

        public  decimal Bill(Dictionary<string,decimal> entities,string product)
        {
            var bill = 0.0m;
            bill = Math.Round(ShopList[product] * entities[product],2);
            return bill;
        }
    }

    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var entities = new Dictionary<string, decimal>();
            var listOfCustomers = new List<Customer>();

            for (int i = 0; i < n; i++)
            {
                var entity = Console.ReadLine().Split('-');
                var product = entity[0];
                var price = decimal.Parse(entity[1]);

                entities[product] = price;
            }

            var inputLine = Console.ReadLine();

            while (inputLine != "end of clients")
            {
                var inputParams = inputLine.Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);

                var name = inputParams[0];
                var product = inputParams[1];
                var quantity = int.Parse(inputParams[2]);

                var currentCustomer = new Customer
                {
                    Name = name,
                    ShopList = new Dictionary<string, int>()
                };

                if (entities.ContainsKey(product))
                {
                    currentCustomer.ShopList[product] = quantity;

                    listOfCustomers.Add(currentCustomer);
                }
                
                inputLine = Console.ReadLine();
            }

            listOfCustomers = listOfCustomers.OrderBy(x => x.Name).ToList();

            var totalBill = 0.0m;
            foreach (var customer in listOfCustomers)
            {
                Console.WriteLine($"{customer.Name}");
                foreach (var product in customer.ShopList)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                foreach (var product in entities)
                {
                    if (customer.ShopList.ContainsKey(product.Key))
                    {
                        Console.WriteLine($"Bill: {customer.Bill(entities, product.Key):F2}");
                        totalBill += customer.Bill(entities,product.Key);
                    }
                }
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }
}
