using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DishRecipeApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DishesRecipesDbContext(serviceProvider.GetRequiredService<DbContextOptions<DishesRecipesDbContext>>()))
            {
                // Look for any movies.
                if (context.Dishes.Any())
                {
                    return;   // DB table has been seeded
                }

                context.Dishes.AddRange(
                    new Dish
                    {
                        Name = "Baked potatoes",
                        Description = "Tasty",
                        DishCategory = DishCategory.MainDish,
                        DateAdded = DateTime.Parse("1989-2-12")
                    },

                    new Dish
                    {
                        Name = "Chicken salad",
                        Description = "Healthy",
                        DishCategory = DishCategory.Appetizer,
                        DateAdded = DateTime.Parse("2020-2-2")
                    },

                     new Dish
                     {
                         Name = "Strawberry Smoothie ",
                         Description = "Very Healthy",
                         DishCategory = DishCategory.Desert,
                         DateAdded = DateTime.Parse("2020-6-25")
                     },

                    new Dish
                    {
                        Name = "Tomato soup",
                        Description = "Good",
                        DishCategory = DishCategory.Soup,
                        DateAdded = DateTime.Parse("2020-1-25")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
