using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static RecipeApp.IO.FileFormats;

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
            foreach (Ingredient ingredient in recipe.RawIngredients)
            {
                Console.WriteLine($"{ingredient.Name}. {ingredient.Instructions}");
            }
        }
        public static void PrintExistingRecipes(string FileName, FileTypes format)
        {
            //Check if file exists
            if (File.Exists(FileName))
            {
                //Check if there is actually text stored
                if (new FileInfo(FileName).Length > 0)
                {
                    Console.WriteLine("Existing recipes are:");
                    //Print recipe
                    PrintRecipe(FileName, format);
                }
            }
        }
        private static void PrintRecipe(string FileName, FileTypes format)
        {
            int index = 1;
            List<Recipe> recipes = RecipeLoader.LoadFromFile(FileName, format);
            foreach (Recipe recipe in recipes)
            {
                Console.WriteLine($"***** {index} *****");
                PrintRecipe(recipe);
                Console.WriteLine(" ");
                index++;
            }
        }
    }
}
