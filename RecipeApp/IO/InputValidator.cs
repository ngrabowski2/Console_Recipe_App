using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.IO
{
    public static class InputValidator
    {
        public static bool IsInputValid(string input, out int number) => int.TryParse(input, out number);
        public static bool IsIngredientIdValid(int id, int totalAmount) => id > 0 && id < totalAmount;
    }
}
