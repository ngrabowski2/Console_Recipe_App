using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.IO
{
    public static class IngredientPrinter
    {
        public static void Print(List<Ingredient> ingredients)
        {
            foreach (Ingredient ingredient in ingredients) Console.WriteLine($"{ingredient.ID}. {ingredient.Name}");
        }
    }
}
