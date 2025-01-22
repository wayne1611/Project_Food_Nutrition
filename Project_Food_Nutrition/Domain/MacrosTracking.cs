namespace Project_Food_Nutrition.Domain
{
    public class MacrosTracking : BaseDomainModel
    {
        // The date for which the macros are being tracked
        public DateTime Date { get; set; }

        // Total calories consumed
        public double Calories { get; set; }

        // Amount of protein consumed (in grams)
        public double Protein { get; set; }

        // Amount of carbohydrates consumed (in grams)
        public double Carbohydrates { get; set; }

        // Amount of fats consumed (in grams)
        public double Fats { get; set; }

    }
}
