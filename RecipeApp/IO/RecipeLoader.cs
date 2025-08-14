using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static RecipeApp.IO.FileFormats;

namespace RecipeApp.IO
{
    public static class RecipeLoader
    {

        public static List<Recipe> LoadFromFile(string file, FileTypes format)
        {
            List<Recipe> result = new List<Recipe>();
            List<string> lines;
            if (format is FileTypes.Txt) lines = ParseTxt(file);
            else if (format is FileTypes.Json) lines = ParseJson(file);
            else return result;

            foreach (string line in lines)
            {
                List<Ingredient> ingredients = ConvertToIngredientList(line);
                result.Add(new Recipe(ingredients));
            }
            return result;
        }

        public static List<string> ParseTxt(string file) => new List<string>(File.ReadAllLines(file));

        public static List<string> ParseJson(string file) => JsonSerializer.Deserialize<List<string>>(File.ReadAllText(file));

        private static List<Ingredient> ConvertToIngredientList(string line)
        {
            List<Ingredient> ingredients = IngredientListGenerator.Generate();
            //Convert strings to ingredients
            IngredientSelector selector = new IngredientSelector();
            List<int> ingredientList = line.Split(',').Select(int.Parse).ToList();
            foreach (int ingredient in ingredientList)
            {
                selector.Select(ingredients[ingredient - 1]);
            }

            return selector.Ingredients;
        }
    }
}
