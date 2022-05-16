using SimpleFactoryConsole.Factories;
using SimpleFactoryConsole.Pizzas;

namespace SimpleFactoryConsole.PizzaStores
{
    public class PizzaStore
    {
        public SimplePizzaFactory Factory { get; set; }

        public PizzaStore(SimplePizzaFactory factory)
        {
            Factory = factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = Factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}
