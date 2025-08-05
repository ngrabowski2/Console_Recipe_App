using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public class IngredientSelector
    {
        public List<Ingredient> Ingredients { get; private set; }

        public IngredientSelector()
        {
            Ingredients = new List<Ingredient>();
        }

        public void Select(Ingredient ingredient)
        {
            Ingredients.Add(ingredient);
        }
    }
}
