using AbstractFactory.Factories;
using System;

namespace AbstractFactory.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            IngredientFactory = ingredientFactory;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = IngredientFactory.CreateDough();
            Sauce = IngredientFactory.CreateSauce();
            Cheese = IngredientFactory.CreateCheese();
        }
    }
}
