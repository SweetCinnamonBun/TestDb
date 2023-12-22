using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestDb.Models;

namespace TestDb.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IngredientsController : ControllerBase
{
    private readonly RecipesWebsiteDbTestContext recipesWebsiteDbTestContext;

    public IngredientsController(RecipesWebsiteDbTestContext recipesWebsiteDbTestContext)
    {
        this.recipesWebsiteDbTestContext = recipesWebsiteDbTestContext;
    }

    [HttpGet]
    public IActionResult Get()
    {
        var ingredients = recipesWebsiteDbTestContext.Ingredients.ToList();

        return Ok(ingredients);
    }

    [HttpPost]

    public IActionResult Post([FromBody] IngredientDto ingredient)
    {
        var ingredientDomain = new Ingredient
        {
            Name = ingredient.Name
        };

        recipesWebsiteDbTestContext.Ingredients.Add(ingredientDomain);
        recipesWebsiteDbTestContext.SaveChanges();

        return Ok(ingredientDomain);
    }
}
