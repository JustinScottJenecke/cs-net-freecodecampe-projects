namespace FoodMenuApp.Models;

public class DishIngredient
{
    public int Id { get; set; }
    public Dish Dish {get; set;} = null!;
    public int DishId {get; set;}

    // navigation properties
    public Ingredient Ingredient {get; set;} = null!;
    public int IngredientId {get; set;}
}
