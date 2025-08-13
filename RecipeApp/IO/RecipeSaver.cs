using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static RecipeApp.IO.FileFormats;

namespace RecipeApp.IO
{
    public static class RecipeSaver
    {
        private static void SaveRecipeTxt(Recipe recipe, String file)
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
        private static void SaveRecipeJson(Recipe recipe, String file)
        {
            List<string> recipes;
           
            //If file exists
            if (File.Exists(file))
            {
                //If text already exists, add recipe to end
                if (new FileInfo(file).Length > 0)
                {
                    recipes = JsonSerializer.Deserialize<List<string>>(File.ReadAllText(file));
                    recipes.Add(recipe.ToString());


                } else
                {
                    //If no text exists, just add the new recipe to the file
                    recipes = new List<string>();
                    recipes.Add(recipe.ToString());
                }


                    File.WriteAllText(file, JsonSerializer.Serialize(recipes));
            }
            else
            {
                //If no file exists, create new list and store new recipe
                recipes = new List<string>();
                recipes.Add(recipe.ToString());
                File.WriteAllText(file, JsonSerializer.Serialize(recipes));
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
                Console.WriteLine("Printing Single Recipe");
                Printer.PrintRecipe(recipe);

                //Save the recipe
                if(fileType is FileTypes.Txt) SaveRecipeTxt(recipe, FileName);
                if(fileType is FileTypes.Json) SaveRecipeJson(recipe, FileName);
            }
            else
            //No ingredients selected
            {
                Console.WriteLine("No ingredients have been selected. Recipe will not be saved.");
            }
        }
    }
}
