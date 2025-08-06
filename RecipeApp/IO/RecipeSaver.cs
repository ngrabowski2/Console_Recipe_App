using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.IO
{
    public static class RecipeSaver
    {
        public static void SaveRecipe(Recipe recipe, String file)
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
    }
}
