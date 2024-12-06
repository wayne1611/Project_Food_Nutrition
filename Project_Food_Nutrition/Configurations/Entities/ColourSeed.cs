﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project_Food_Nutrition.Domain;

namespace Project_Food_Nutrition.Configurations.Entities
{
    public class ColourSeed : IEntityTypeConfiguration<Colour>
    {
        public void Configure(EntityTypeBuilder<Colour> builder)
        {
            builder.HasData(
new Colour
{
    Id = 1,
    Name = "Black",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
},
new Colour
{
    Id = 2,
    Name = "Blue",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
    CreatedBy = "System",
    UpdatedBy = "System"
}
);
                
        }
    }
}
