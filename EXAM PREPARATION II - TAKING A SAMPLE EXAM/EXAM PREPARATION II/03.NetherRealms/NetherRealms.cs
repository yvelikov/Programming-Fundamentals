namespace _03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Demon
    {
        public string Name { get; set; }
        public decimal Health { get; set; }
        public decimal Damage { get; set; }
    }
    public class NetherRealms
    {
        public static void Main()
        {
            var demonNames = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var demonsList = new List<Demon>();

            foreach (var name in demonNames)
            {
                var currentDemon = new Demon();
                
                currentDemon.Name = name;

                decimal health = 0;
                foreach (var symbol in name)
                {
                    if ((symbol < 48 || symbol > 57) && symbol != '+' && symbol != '-' && symbol != '*' && symbol != '/' && symbol != '.')
                    {
                        health += symbol;
                    }
                }

                currentDemon.Health = health;

                var digitsRegex = new Regex(@"[-+]?[0-9]+\.?[0-9]*");
                var matches = digitsRegex.Matches(name);

                var digits = new List<decimal>();

                foreach (Match match in matches)
                {
                    decimal number;
                    decimal.TryParse(match.Value, out number);
                    digits.Add(number);
                }

                decimal sum = 0;
                foreach (var number in digits)
                {
                    sum += number;
                }

                foreach (var symbol in name)
                {
                    if (symbol == '/')
                    {
                        sum /= 2;
                    }
                    else if (symbol == '*')
                    {
                        sum *= 2;
                    }

                }
                
                currentDemon.Damage = sum;

                demonsList.Add(currentDemon);
            }

            foreach (var demon in demonsList.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }

        }
    }
}
