using RecipeApp;
using RecipeApp.IO;

//Main Application flow
Console.WriteLine("Create a new cookie Recipe! Available Ingredients are: ");

//Print ingredients
List<Ingredient> ingredients = IngredientListGenerator.Generate();
Printer.PrintIngredients(ingredients);

//Allow user to select ingredients
bool validInput;
IngredientSelector selector = new IngredientSelector();
do
{
    Console.WriteLine("Add an ingredient by its ID or type anything else if finished.");
    //User input
    string input = Console.ReadLine();
    int ingredientID;

    //Checks if input is number
    validInput = InputValidator.IsInputValid(input, out ingredientID);

    //Add if ID is in valid range, skip if user entered a string
    if (validInput && InputValidator.IsIngredientIdValid(ingredientID, ingredients.Count)) selector.Select(ingredients[ingredientID - 1]); //Must convert to index 0

} while (validInput);

//Save the new recipe
Recipe recipe = new Recipe(selector.Ingredients);

//Print the new recipe

Console.WriteLine("Press any key to exit.");
Console.ReadKey();