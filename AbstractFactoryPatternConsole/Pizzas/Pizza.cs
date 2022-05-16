using AbstractFactory.Cheeses;
using AbstractFactory.Clams;
using AbstractFactory.Doughs;
using AbstractFactory.Factories;
using AbstractFactory.Pepperonies;
using AbstractFactory.Sauces;
using AbstractFactory.Veggies;
using System;
using System.Collections.Generic;

namespace AbstractFactory.Pizzas
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public IEnumerable<Veggie> Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clam Clams { get; set; }
        public PizzaIngredientFactory IngredientFactory { get; set; }
        public abstract void Prepare();        
        public virtual void Bake() => Console.WriteLine("Baking for 25 minutes at 350");
        public virtual void Cut() => Console.WriteLine("Cutting the pizza in diagonal slices");
        public virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");
    }
}
