using System;
using System.Linq;
using System.Collections.Generic;

namespace P03ProductShop
{
    class Program
    {
        static void Main()
        {
            string input;

            Dictionary<string, Dictionary<string, double>> dictShopProductPrice = new Dictionary<string, Dictionary<string, double>>();

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] splitedInput = input
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string shop = splitedInput[0];
                string product = splitedInput[1];
                double price = double.Parse(splitedInput[2]);

                if (!dictShopProductPrice.ContainsKey(shop))
                {
                    dictShopProductPrice.Add(shop, new Dictionary<string, double>());
                }

                if (!dictShopProductPrice[shop].ContainsKey(product))
                {
                    dictShopProductPrice[shop].Add(product, price);
                }
            }

            foreach (var item in dictShopProductPrice.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}->");
                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
