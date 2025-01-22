using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_Food_Nutrition.Configurations.Entities;
using Project_Food_Nutrition.Data;

namespace Project_Food_Nutrition.Data
{
    public class Project_Food_NutritionContext(DbContextOptions<Project_Food_NutritionContext> options) : IdentityDbContext<Project_Food_NutritionUser>(options)
    {
        public DbSet<Project_Food_Nutrition.Domain.Recipe> Recipe { get; set; } = default!;

        public DbSet<Project_Food_Nutrition.Domain.Macros> Macros { get; set; } = default!;

        public DbSet<Project_Food_Nutrition.Domain.Calories> Calories { get; set; } = default!;
        public DbSet<Project_Food_Nutrition.Domain.MacrosTracking> MacrosTracking { get; set; } = default!;
        public DbSet<Project_Food_Nutrition.Domain.Staff> Staff{ get; set; } = default!;
        public DbSet<Project_Food_Nutrition.Domain.Users> User { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CaloriesSeed());
            builder.ApplyConfiguration(new RecipeSeed());
            builder.ApplyConfiguration(new MacrosSeed());
        }

    }
}
