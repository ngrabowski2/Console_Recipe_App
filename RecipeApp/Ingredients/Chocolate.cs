using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Ingredients
{
    public class Chocolate : Ingredient
    {
        public override int ID => 4;
        public override string Name => "Chocolate";
        public override string Instructions => "Melt in a water bath. Add to other ingredients.";
    }
}
