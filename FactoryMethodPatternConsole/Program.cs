using FactoryMethod.Pizzas;
using FactoryMethod.PizzaStores;
using System;

namespace FactoryMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string type = "cheese";
            Pizza pizza = null;
            PizzaStore pizzaStore = null;

            pizzaStore = new NYPizzaStore();
            pizza = pizzaStore.OrderPizza(type);

            Console.WriteLine();

            pizzaStore = new ChicagoPizzaStore();
            pizza = pizzaStore.OrderPizza(type);
        }
    }
}
