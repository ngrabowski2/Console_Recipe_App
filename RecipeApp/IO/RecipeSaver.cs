using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RecipeApp.IO.FileFormats;

namespace RecipeApp.IO
{
    public static class RecipeSaver
    {
        public static void SaveRecipeTxt(Recipe recipe, String file)
        {
            if (File.Exists(file))
            {
                //If text already exists, add a newline
                if (new FileInfo(file).Length > 0) File.AppendAllText(file, Environment.NewLine);
                File.AppendAllText(file, recipe.ToString());
            } else
            {
                File.WriteAllText(file, recipe.ToString());
            }
        }

        public static void SaveRecipe(IngredientSelector selector, string FileName, FileTypes fileType)
        {
            //Check if user selected ingredients
            if (selector.Ingredients.Count > 0)
            {
                //Save the new recipe
                Recipe recipe = new Recipe(selector.Ingredients);

                //Print the new recipe
                Printer.PrintRecipe(recipe);

                //Save the recipe
                if(fileType is FileTypes.Txt) RecipeSaver.SaveRecipeTxt(recipe, FileName);
            }
            else
            //No ingredients selected
            {
                Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
            }
        }
    }
}
