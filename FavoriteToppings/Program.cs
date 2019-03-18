using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FavoriteToppings
{
    class Program
    {
        static void Main(string[] args)
        {
            var allThePizzas = File.ReadAllText(@"C:\Users\Shane D Wilson\source\repos\FavoriteToppings\pizzas.json");
            List<Pizza> allPizzaOrders = JsonConvert.DeserializeObject<List<Pizza>>(allThePizzas);

            var orderedPizzas = allPizzaOrders
                .Select(pizza => pizza.ToString())
                .GroupBy(pizza => pizza)
                .OrderByDescending(toppings => toppings.Count())
                .Select(s => new { s.Key, Number = s.Count() });

            var top20 = orderedPizzas.Take(20);

            foreach (var pizza in top20)
            {
                Console.WriteLine($"{pizza.Key} occurs {pizza.Number} times");
            }

            Console.ReadKey();
        }
    }
}
