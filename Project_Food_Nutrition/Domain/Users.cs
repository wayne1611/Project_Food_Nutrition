namespace Project_Food_Nutrition.Domain
{
    public class Users : BaseDomainModel
    {
        
        public string? UserName { get; set; }   
        public string? UserDietName { get; set; }
        public int DailyCaloriesRecommend { get; set; }
        public int CurrentCalories { get; set; }
        public string? CaloriesDate { get; set; }
        public string? CaloriesTime { get; set; }

        // Foreign key to Recipe
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }

        // Navigation property for the relationship to NutritionalGoal
        public ICollection<Calorie>? Calories { get; set; }
    }
}
