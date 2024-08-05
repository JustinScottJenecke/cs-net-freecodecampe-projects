using FoodMenuApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodMenuApp.Data;

public class FoodMenuContext : DbContext
{
    public FoodMenuContext( DbContextOptions<FoodMenuContext> dbContextOptions ) : base(dbContextOptions)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // specify many to many relationship between Dish and Ingredient
        modelBuilder.Entity<DishIngredient>().HasKey(di => new
        {
            di.DishId,
            di.IngredientId
        });

        // specify relationship between Dish and DishIngredient
        modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.Dish);
        // specify relationship between Ingredient and DishIngredient
        modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.Ingredient);


        base.OnModelCreating(modelBuilder);
    }
}
