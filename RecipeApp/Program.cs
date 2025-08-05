using RecipeApp;
using RecipeApp.IO;

//Main Application flow
Console.WriteLine("Create a new cookie Recipe! Available Ingredients are: ");

//Print ingredients
List<Ingredient> ingredients = IngredientListGenerator.Generate();
IngredientPrinter.Print(ingredients);

//Allow user to select ingredients
bool validInput;
IngredientSelector selector = new IngredientSelector();
do
{
    Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
    //User input
    string input = Console.ReadLine();
    int ingredientID;
    validInput = int.TryParse(input, out ingredientID);

    //Add if valid
    if (validInput && ingredientID > 0 && ingredientID <= ingredients.Count)
    {
        //Must convert to index 0
        selector.Select(ingredients[ingredientID-1]);
    }
} while (validInput);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();