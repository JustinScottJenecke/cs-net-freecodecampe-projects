namespace FoodMenuApp.Models;

public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    // navigation properties
    public List <Dish>? Dishes {get; set;}
}
