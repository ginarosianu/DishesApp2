using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DishRecipeApp.Models;

namespace DishesApp.Data
{
    public class DishesAppContext : DbContext
    {
        public DishesAppContext (DbContextOptions<DishesAppContext> options)
            : base(options)
        {
        }

        public DbSet<DishRecipeApp.Models.Dish> Dish { get; set; }
    }
}
