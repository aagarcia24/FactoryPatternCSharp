using AbstractFactory.Factories;
using System;

namespace AbstractFactory.Pizzas
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
            Clams = IngredientFactory.CreateClams();
        }
    }
}
