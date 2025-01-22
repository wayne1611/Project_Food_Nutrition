
namespace Project_Food_Nutrition.Domain
{
    public class Calories : BaseDomainModel
    {
        public string? Name { get; set; }
        public int? CaloriesCount { get; set; }


        // Foreign key to Users
        public int UserName { get; set; }
        public Users? User { get; set; }
    }
}
