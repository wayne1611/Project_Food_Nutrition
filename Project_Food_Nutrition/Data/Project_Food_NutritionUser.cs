using Microsoft.AspNetCore.Identity;

namespace Project_Food_Nutrition.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class Project_Food_NutritionUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


    }
}
