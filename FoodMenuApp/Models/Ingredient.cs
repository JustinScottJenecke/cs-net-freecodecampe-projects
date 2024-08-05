namespace FoodMenuApp.Models;

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;

    // navigation properties
    public List <DishIngredient>? DishIngredients {get; set;}
}
