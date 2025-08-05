using RecipeApp;
using RecipeApp.IO;

//Main Application flow
//Welcome

Console.WriteLine("Create a new cookie Recipe! Available Ingredients are: ");
//Print ingredients
List<Ingredient> ingredients = IngredientListGenerator.Generate();
IngredientPrinter.Print(ingredients);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();