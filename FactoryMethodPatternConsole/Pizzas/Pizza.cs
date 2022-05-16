using System;
using System.Collections.Generic;

namespace FactoryMethod.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }

        public List<string> Toppings { get; set; } = new List<string>();
        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine($"Tossing dough... {Dough}");
            Console.WriteLine($"Adding sauce... {Sauce}");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in Toppings)
                Console.WriteLine($"\t{topping}");
        }
        public virtual void Bake() => Console.WriteLine("Baking for 25 minutes at 350");

        public virtual void Cut() => Console.WriteLine("Cutting the pizza in diagonal slices");

        public virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");
    }
}
