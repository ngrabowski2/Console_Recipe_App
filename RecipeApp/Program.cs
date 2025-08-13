using RecipeApp;
using RecipeApp.IO;
using static RecipeApp.IO.FileFormats;
//File to store or check recipes
const string FileName = "recipes";
const FileTypes FileFormat = FileTypes.Txt;

//Main Application flow
//Print existing recipes
Printer.PrintExistingRecipes(FileName, FileFormat);

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

//Save recipe
RecipeSaver.SaveRecipe(selector, FileName, FileFormat);

Console.WriteLine("Press any key to exit.");
Console.ReadKey();