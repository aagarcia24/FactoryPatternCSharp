using SimpleFactoryConsole.Factories;
using SimpleFactoryConsole.PizzaStores;
using System;

namespace SimpleFactoryConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore = new PizzaStore(new SimplePizzaFactory());
            pizzaStore.OrderPizza("cheese");
            Console.WriteLine();
            pizzaStore.OrderPizza("clam");
        }
    }
}
