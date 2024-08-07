/*

using FoodMenuApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodMenuApp.Data;

public class DeprFoodMenuContext : DbContext
{
    public DbSet<Dish> Dishes {get; set;}
    public DbSet<Ingredient> Ingredients {get; set;}
    public DbSet<DishIngredient> DishIngredients {get; set;}

    public DeprFoodMenuContext( DbContextOptions<FoodMenuContext> dbContextOptions ) : base(dbContextOptions)
    {

    }

    // sql server configured in program.cs
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer(@"Data Source=");
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // === Relational Mapping ===
        // specify many to many relationship between Dish and Ingredient
        modelBuilder.Entity<DishIngredient>().HasKey(di => new
        {
            di.DishId,
            di.IngredientId
        });

        // specify relationship between Dish and DishIngredient
        // modelBuilder.Entity<DishIngredient>().HasOne(d => d.Dish).WithMany(di => di.DishIngredients).HasForeignKey(d => d.Dish);
        
        // specify relationship between Ingredient and DishIngredient
        // modelBuilder.Entity<DishIngredient>().HasOne(i => i.Ingredient).WithMany(di => di.DishIngredients).HasForeignKey(i => i.Ingredient);

        // === Data Seeding ===

        modelBuilder.Entity<Dish>().HasData([
            new Dish 
            {
                Id = 1, 
                Name = "Pizza", 
                ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRFGEvi1oeegc4XlyDdmxByl8C-o-bO7iC3bw&s",
                Price = 70.00
            },
            new Dish
            {
                Id = 2, 
                Name = "Cheese Burger", 
                ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQBFCimCM1wFvb3FZQOZH_j5ta4Qd2SlNj2vg&s",
                Price = 70.00
            }
        ]);

        modelBuilder.Entity<Ingredient>().HasData(
            new Ingredient {Id = 1,Name = "Cheese"},
            new Ingredient {Id = 2,Name = "Tomato Sauce"},
            new Ingredient {Id = 3,Name = "Peperoni"},
            new Ingredient {Id = 4,Name = "Pizza Dough"},
            new Ingredient {Id = 5,Name = "Olive Oil"},
            new Ingredient {Id = 6,Name = "Hamburger Roll"},
            new Ingredient {Id = 7,Name = "Lettuce"},
            new Ingredient {Id = 8,Name = "Burger Patty"}
        );

        modelBuilder.Entity<DishIngredient>().HasData(
            // pizza
            new DishIngredient {DishId = 1, IngredientId = 1},
            new DishIngredient {DishId = 1, IngredientId = 2},
            new DishIngredient {DishId = 1, IngredientId = 3},
            new DishIngredient {DishId = 1, IngredientId = 4},
            new DishIngredient {DishId = 1, IngredientId = 5},

            // cheese burger
            new DishIngredient {DishId = 2, IngredientId = 1},
            new DishIngredient {DishId = 2, IngredientId = 6},
            new DishIngredient {DishId = 2, IngredientId = 7},
            new DishIngredient {DishId = 2, IngredientId = 8},
            new DishIngredient {DishId = 2, IngredientId = 2}
        );

        base.OnModelCreating(modelBuilder);
    }

}
*/