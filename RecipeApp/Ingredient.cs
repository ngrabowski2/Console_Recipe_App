using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp
{
    public abstract class Ingredient
    {
        public virtual int ID { get; }
        public virtual string Name { get; } = "Ingredient";
        public virtual string Instructions { get; } = "Add to other ingredients";
    }
}
