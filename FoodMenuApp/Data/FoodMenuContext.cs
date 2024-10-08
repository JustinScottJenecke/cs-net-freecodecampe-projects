﻿using FoodMenuApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodMenuApp.Data;

public class FoodMenuContext : DbContext
{
    public DbSet<Dish> Dishes {get; set;}
    public DbSet<Ingredient> Ingredients {get; set;}
    public DbSet<DishIngredient> DishIngredients {get; set;}

    public FoodMenuContext( DbContextOptions<FoodMenuContext> dbContextOptions ) : base(dbContextOptions)
    {

    }

    // sql server configured in program.cs
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.UseSqlServer(@"Data Source=");
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Explicit data mapping 
        modelBuilder.Entity<Dish>()
            .HasMany(dish => dish.Ingredients)
            .WithMany(ingredient => ingredient.Dishes)
            .UsingEntity<DishIngredient>();

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
            new DishIngredient {Id = 1, DishId = 1, IngredientId = 1},
            new DishIngredient {Id = 2, DishId = 1, IngredientId = 2},
            new DishIngredient {Id = 3, DishId = 1, IngredientId = 3},
            new DishIngredient {Id = 4, DishId = 1, IngredientId = 4},
            new DishIngredient {Id = 5, DishId = 1, IngredientId = 5},

            // cheese burger
            new DishIngredient {Id = 6, DishId = 2, IngredientId = 1},
            new DishIngredient {Id = 7,DishId = 2, IngredientId = 6},
            new DishIngredient {Id = 8 ,DishId = 2, IngredientId = 7},
            new DishIngredient {Id = 9,DishId = 2, IngredientId = 8},
            new DishIngredient {Id = 10,DishId = 2, IngredientId = 2}
        );

        base.OnModelCreating(modelBuilder);
    }

}
