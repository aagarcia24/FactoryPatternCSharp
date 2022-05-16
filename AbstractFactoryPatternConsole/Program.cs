using AbstractFactory.Pizzas;
using AbstractFactory.PizzaStores;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string type = "clam";
            
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizza pizza = pizzaStore.OrderPizza(type);
        }
    }
}
