using System;

namespace RecipeApp.Ingredients
{
    public abstract class Spice : Ingredient
    {
        public override string Instructions => "Take half a teaspoon. Add to other ingredients.";
    }
}