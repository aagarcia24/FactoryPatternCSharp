using FactoryMethod.Pizzas;
using FactoryMethod.Pizzas.ChicagoStyle;

namespace FactoryMethod.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type == "cheese")
                return new ChicagoStyleCheesePizza();
            if (type == "veggie")
                return new ChicagoStyleVeggiePizza();
            if (type == "clam")
                return new ChicagoStyleClamPizza();
            if (type == "pepperoni")
                return new ChicagoStylePepperoniPizza();
            else
                return null;
        }
    }
}
