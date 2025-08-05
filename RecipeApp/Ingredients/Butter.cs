using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Ingredients
{
    public class Butter : Ingredient
    {
        public override int ID => 3;
        public override string Name => "Butter";
        public override string Instructions => "Melt on low heat. Add to other ingredients.";
    }
}
