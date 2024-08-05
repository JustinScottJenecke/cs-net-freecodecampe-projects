namespace FoodMenuApp.Models;

public class Dish
{
    public int Id {get; set;}
    public string Name {get; set;} = String.Empty;
    public string ImgUrl {get; set;} = String.Empty;
    public double Price {get; set;}

    // navigation properties
    public List <DishIngredient>? DishIngredients {get; set;}
}
