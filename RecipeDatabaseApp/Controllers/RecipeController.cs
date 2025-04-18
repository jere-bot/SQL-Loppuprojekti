using Microsoft.EntityFrameworkCore;

namespace RecipeDatabaseApp.Controllers
{
    public class RecipeController
    {
        // Update the DbContext to match your dbContext, e.g. WebStoreContext
        private readonly DbContext _dbContext;

        // Update the DbContext to match your dbContext, e.g. WebStoreContext
        public RecipeController(DbContext context)
        {
            _dbContext = context;
        }

        /// <summary>
        /// Retrieves all recipes from the database and prints them to the console.
        /// Implementation should use EF Core to fetch Recipe entities
        /// and display relevant fields (e.g., ID, Name).
        /// </summary>
        public async Task ListAllRecipes()
        {
            // Print out all Recipes
            Console.WriteLine("Example recipe list output");
        }

        /// <summary>
        /// Associates an existing Category with a specified Recipe,
        /// based on user input (e.g., recipe ID/name and category name).
        /// The method should validate that both Recipe and Category
        /// exist, then create the necessary relationship in the database.
        /// </summary>
        internal async Task AddCategoryToRecipe()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Allows the user to add a new Ingredient to the database,
        /// specifying properties such as Name, Type, and any optional
        /// nutritional details. Should use EF Core to create and
        /// save the new Ingredient entity.
        /// </summary>
        internal async Task AddNewIngredient()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new Recipe entry by prompting the user for
        /// recipe details (name, description, etc.). 
        /// Implementation should add a new Recipe entity via EF Core
        /// and save changes to the database.
        /// </summary>
        internal async Task AddNewRecipe()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an existing Recipe from the database by prompting
        /// the user for a Recipe identifier (e.g., ID or name).
        /// Should handle deletion of any related data (e.g., from
        /// RecipeIngredient junction tables) if cascades are not enabled.
        /// </summary>
        internal async Task DeleteRecipe()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Fetches all recipes under a specified category by prompting
        /// the user for the category name. Uses EF Core and LINQ
        /// to filter recipes belonging to that category, then prints 
        /// them to the console.
        /// </summary>
        internal async Task FetchRecipeByCategory()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes a given Category association from a Recipe.
        /// The method should confirm both entities exist, then remove
        /// their relationship in the junction table or foreign key.
        /// </summary>
        internal async Task RemoveCategoryFromRecipe()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Searches for recipes containing all of the user-specified
        /// ingredients. The user can input multiple ingredient names;
        /// the method should return only recipes that include
        /// all those ingredients.
        /// </summary>
        internal async Task SearchRecipeByIngredients()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates fields of an existing Recipe, e.g., Name, Description,
        /// or other metadata. Prompts the user for a Recipe identifier,
        /// retrieves the entity from the database, modifies fields,
        /// and saves changes back to the database.
        /// </summary>
        internal async Task UpdateRecipe()
        {
            throw new NotImplementedException();
        }
    }
}