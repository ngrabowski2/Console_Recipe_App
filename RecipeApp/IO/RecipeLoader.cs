using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.IO
{
    public static class RecipeLoader
    {
        public static List<Recipe> LoadFromTxt(string file)
        {
            List<string> lines = new List<string>(File.ReadAllLines(file));
            List<Recipe> result = new List<Recipe>();
            foreach (string line in lines)
            {
                List<Ingredient> ingredients = ConvertToIngredientList(line);
                result.Add(new Recipe(ingredients));
            }
            return result;
        }

        private static List<Ingredient> ConvertToIngredientList (string line)
        {
            List<Ingredient> ingredients = IngredientListGenerator.Generate();
            //Convert strings to ingredients
            IngredientSelector selector = new IngredientSelector();
            List<int> ingredientList = line.Split(',').Select(int.Parse).ToList();
            foreach (int ingredient in ingredientList) {
                selector.Select(ingredients[ingredient - 1]);
            }

            return selector.Ingredients;
        }
    }
}
