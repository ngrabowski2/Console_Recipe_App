using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.IO
{
    public static class Printer
    {
        public static void PrintIngredients(List<Ingredient> ingredients)
        {
            foreach (Ingredient ingredient in ingredients) Console.WriteLine($"{ingredient.ID}. {ingredient.Name}");
        }
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine("Printing Single Recipe");

            foreach (Ingredient ingredient in recipe.RawIngredients)
            {
                Console.WriteLine($"{ingredient.Name}. {ingredient.Instructions}");
            }
        }
    }
}
