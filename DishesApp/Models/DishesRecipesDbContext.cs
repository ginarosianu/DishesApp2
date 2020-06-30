using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DishRecipeApp.Models
{
    public class DishesRecipesDbContext : IdentityDbContext
    {
        public DishesRecipesDbContext(DbContextOptions<DishesRecipesDbContext> options) : base(options) {}

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }    
    }
}