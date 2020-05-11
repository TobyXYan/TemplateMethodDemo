using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDemo
{
    public class VeggeHoogie : Hoogie
    {
        string[] VeggiesUsed = { "Lettuce", "Tomatos", "Onions", "Sweet Peppers" };
        string[] CondimentsUsed = { "Oil", "Vinegar" };


        public override void AddCheese()
        {
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
