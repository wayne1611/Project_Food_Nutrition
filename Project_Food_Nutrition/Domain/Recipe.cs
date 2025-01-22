namespace Project_Food_Nutrition.Domain
{
    public class Recipe : BaseDomainModel
    {
        public string?  Name { get; set; }
        public string? Ingredients { get; set; }
        public string? Instructions { get; set; }

        // Navigation property to the FoodItem
        public ICollection<Macros>? Macros { get; set; }

        // Navigation property for the relationship with Users
        public ICollection<Users>? Users { get; set; }
    }
}
