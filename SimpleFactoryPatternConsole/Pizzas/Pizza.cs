using System;

namespace SimpleFactoryConsole.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public void Prepare() 
        {
            Console.WriteLine($"Preparing {Name}");
        }
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

    }
}
