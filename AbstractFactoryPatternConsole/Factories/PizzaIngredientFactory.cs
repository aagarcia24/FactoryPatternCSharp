using AbstractFactory.Cheeses;
using AbstractFactory.Clams;
using AbstractFactory.Doughs;
using AbstractFactory.Pepperonies;
using AbstractFactory.Sauces;
using AbstractFactory.Veggies;
using System.Collections.Generic;

namespace AbstractFactory.Factories
{
    public interface PizzaIngredientFactory
    {
        public Dough CreateDough();
        public Sauce CreateSauce();
        public Cheese CreateCheese();
        public IEnumerable<Veggie> CreateVeggies();
        public Pepperoni CreatePepperoni();
        public Clam CreateClams();
    }
}
