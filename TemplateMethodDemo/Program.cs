using System;

namespace TemplateMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var italianHoogie = new ItalianHoogie();
            italianHoogie.MakeSandwitch();

            var veggeHoogie = new VeggeHoogie();
            veggeHoogie.MakeSandwitch();
            Console.ReadLine();
        }
    }
}
