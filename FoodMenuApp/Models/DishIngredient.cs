namespace FoodMenuApp.Models;

public class DishIngredient
{
    public int Id { get; set; }
    // public Dish Dish {get; set;} = null!;
    //public Ingredient Ingredient {get; set;} = null!;
    
    // navigation properties
    public int DishId {get; set;}
    public int IngredientId {get; set;}
}
