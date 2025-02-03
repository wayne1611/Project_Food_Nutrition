namespace Project_Food_Nutrition.Domain
{
    public class CalorieProgress
    {
        public int Id { get; set; }
        public int TargetCalories { get; set; }
        public int TotalCalories { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
