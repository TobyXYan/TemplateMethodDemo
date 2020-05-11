using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDemo
{
    public abstract class Hoogie
    {
        public virtual void MakeSandwitch()
        {
            CutBun();

            if (CustomerWantsMeat())
                AddMeat();
            if (CustomerWantsCheese())
                AddCheese();
            if (CustomerWantsVegetables())
                AddVegetables();
            if (CustomerWantsCondiments())
                AddCondiments();

            WrapTheHoogie();
        }


        public void CutBun()
        {
            Console.WriteLine("Cut Bun");
        }

        public void WrapTheHoogie()
        {
            Console.WriteLine("Wrap the hoogie");
        }

    public abstract void AddMeat();
        public abstract void AddCheese();
        public abstract void AddVegetables();
        public abstract void AddCondiments();


        public bool CustomerWantsMeat() { return true; }
        public bool CustomerWantsCheese() { return true; }
        public bool CustomerWantsVegetables() { return true; }
        public bool CustomerWantsCondiments() { return true; }

    }
}
