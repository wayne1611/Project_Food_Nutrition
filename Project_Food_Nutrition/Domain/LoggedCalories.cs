namespace Project_Food_Nutrition.Domain
{


    public class LoggedCalorie
    {
        public int Id { get; set; }
        public int MealId { get; set; }
        public string? MealName { get; set; }
        public int? CaloriesCount { get; set; }
    }
}