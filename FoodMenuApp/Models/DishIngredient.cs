namespace FoodMenuApp.Models;

public class DishIngredient
{
    public int Id { get; set; }
    public Dish Dish {get; set;}
    public int DishId {get; set;}

    // navigation properties
    public Ingredient Ingredient {get; set;}
    public int IngredientId {get; set;}
}
