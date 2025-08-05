using RecipeApp.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public static class IngredientListGenerator
    {
        public static List<Ingredient> Generate()
        {
            List<Ingredient> result = new List<Ingredient>();
            result.Add(new WheatFlour());
            result.Add(new CoconutFlour());
            result.Add(new Butter());
            result.Add(new Chocolate());
            result.Add(new Sugar());
            result.Add(new Cardamom());
            result.Add(new Cinnamon());
            result.Add(new CocoaPowder());

            return result;
        }
    }
}
