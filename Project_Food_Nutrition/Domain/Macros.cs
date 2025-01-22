

namespace Project_Food_Nutrition.Domain
{
    public class Macros : BaseDomainModel
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? HealthBenefits { get; set; }

        // Foreign key to the Recipe
        public int? RecipeId { get; set; }
        public Recipe? Recipe { get; set; }
    }
}
