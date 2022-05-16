using AbstractFactory.Cheeses;
using AbstractFactory.Clams;
using AbstractFactory.Doughs;
using AbstractFactory.Pepperonies;
using AbstractFactory.Sauces;
using AbstractFactory.Veggies;
using System.Collections.Generic;

namespace AbstractFactory.Factories
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese() => new ReggianoCheese();

        public Clam CreateClams() => new FreshClams();

        public Dough CreateDough() => new ThinCrustDough();

        public Pepperoni CreatePepperoni() => new SlicedPepperoni();

        public Sauce CreateSauce() => new MarinaraSauce();

        public IEnumerable<Veggie> CreateVeggies() => new List<Veggie>() { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
    }
}
