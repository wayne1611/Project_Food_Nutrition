using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Project_Food_Nutrition.Configurations.Entities;
using Project_Food_Nutrition.Data;

namespace Project_Food_Nutrition.Data
{
    public class Project_Food_NutritionContext(DbContextOptions<Project_Food_NutritionContext> options) : IdentityDbContext<Project_Food_NutritionUser>(options)
    {
        public DbSet<Project_Food_Nutrition.Domain.Make> Make { get; set; } = default!;

        public DbSet<Project_Food_Nutrition.Domain.Model> Model { get; set; } = default!;

        public DbSet<Project_Food_Nutrition.Domain.Colour> Color { get; set; } = default!;
        public DbSet<Project_Food_Nutrition.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<Project_Food_Nutrition.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<Project_Food_Nutrition.Domain.Customer> Customer { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }

    }
}
