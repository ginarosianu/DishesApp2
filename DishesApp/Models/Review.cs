namespace DishRecipeApp.Models
{
    public class Review
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public long DishId { get; set; }
        public Dish Dish { get; set; }
    }
}