using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.IO
{
    public class Recipe
    {
        public List<Ingredient> RawIngredients { get; private set; }
        public List<int> IngredientIDs { get; private set; }
        public Recipe(List<Ingredient> ingredients) 
        { 
            RawIngredients = ingredients;
            IngredientIDs = new List<int>();
            foreach (Ingredient ingredient in ingredients)
            {
                IngredientIDs.Add(ingredient.ID);
            }
        }
    }
}
