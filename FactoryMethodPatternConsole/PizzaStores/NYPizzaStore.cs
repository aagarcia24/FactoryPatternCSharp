using FactoryMethod.Pizzas;
using FactoryMethod.Pizzas.NYStyle;

namespace FactoryMethod.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
                return new NYStyleCheesePizza();
            if (type == "veggie")
                return new NYStyleVeggiePizza();
            if (type == "clam")
                return new NYStyleClamPizza();
            if (type == "pepperoni")
                return new NYStylePepperoniPizza();
            else
                return null;
        }
    }
}
