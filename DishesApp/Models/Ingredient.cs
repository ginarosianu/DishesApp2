using System.Net.NetworkInformation;

namespace DishRecipeApp.Models
{   
        public enum IngredientType 
        {
            Meat,
            Vegetable,
            Dairy,
            Fish
        }

        public enum Origin
        {
            Romania,
            EU,
            OtherCountries
        }

        public class Ingredient
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public IngredientType IngredientType {get; set;}
            public Origin Origin { get; set; }
            public long DishId { get; set; }
            public Dish Dish { get; set; }
        }
   
}