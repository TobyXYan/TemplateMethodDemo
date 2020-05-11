using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDemo
{
    public class ItalianHoogie:Hoogie
    {
        string[] MeatUsed       = { "Salami", "Pepperoni", "Capicola Ham" };
        string[] CheeseUsed     = { "Provolone"};
        string[] VeggiesUsed    = { "Lettuce", "Tomatos", "Onions", "Sweet Peppers" };
        string[] CondimentsUsed = { "Oil", "Vinegar" };

        public override void AddCheese()
        {
            Console.WriteLine("Start to add cheese:");
            foreach (var cheese in CheeseUsed)
            {
                Console.WriteLine($"Add meat of {cheese}");
            }
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Start to add condiment:");
            foreach (var condiment in CondimentsUsed)
            {
                Console.WriteLine($"Add meat of {condiment}");
            }
        }

        public override void AddMeat()
        {
            Console.WriteLine("Start to add meat:");
            foreach (var meat in MeatUsed)
            {
                Console.WriteLine($"Add meat of {meat}");
            }
        }

        public override void AddVegetables()
        {
            Console.WriteLine("Start to add Vegitables:");
            foreach (var vege in VeggiesUsed)
            {
                Console.WriteLine($"Add meat of {vege}");
            }
        }

    }
}
