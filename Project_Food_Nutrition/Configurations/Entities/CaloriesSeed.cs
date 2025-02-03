using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_Food_Nutrition.Domain;

namespace Project_Food_Nutrition.Configurations.Entities
{
    public class CaloriesSeed : IEntityTypeConfiguration<Calorie>
    {
        public void Configure(EntityTypeBuilder<Calorie> builder)
        {
            builder.HasData(
new Calorie
{
    Id = 1,
    Name = "Chicken Salad",
    CaloriesCount = 750,
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},

new Calorie
{
    Id = 2,
    Name = "Grilled Chicken Sandwich",
    CaloriesCount = 400,
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},

new Calorie
{
    Id = 3,
    Name = "Avocado Toast with egg ",
    CaloriesCount = 250,
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},


new Calorie
{
    Id = 4,
    Name = "Spaghetti Bolognese (1 plate)",
    CaloriesCount = 600,
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},



new Calorie
{
    Id = 5,
    Name = "Grilled salmon with quinoa and vegetables (1 plate)",
    CaloriesCount = 450,
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},


new Calorie
{
    Id = 6,
    Name = "Apple slices with peanut butter (1 serving)",
    CaloriesCount = 200,
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},

new Calorie
{
    Id = 7,
    Name = "Chocolate chip cookies (1 cookie)",
    CaloriesCount = 100,
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
}

);
                
        }
    }
}
