﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Ingredients
{
    public abstract class Flour : Ingredient
    {
        public override string Instructions => "Sieve. Add to other ingredients.";
    }
}
