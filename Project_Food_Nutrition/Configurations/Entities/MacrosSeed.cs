using Project_Food_Nutrition.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Project_Food_Nutrition.Configurations.Entities
{
    public class MacrosSeed : IEntityTypeConfiguration<Macros>
    {
        public void Configure(EntityTypeBuilder<Macros> builder)
        {
            builder.HasData(
new Macros
{
    Id = 2,
    Name = "Chicken Breast",
    Description = "165 calories.\r\n3.6 g of cholesterol.\r\n31 g of protein.\r\n3.6 g of fat.\r\n0 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0 g of total sugars.\r\n",
    HealthBenefits = "High in protein, promotes muscle growth and repair.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 3,
    Name = "Beef Steak",
    Description = "242 calories.\r\n78 mg of cholesterol.\r\n22.8 g of protein.\r\n16.3 g of fat.\r\n0 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0 g of total sugars.\r\n",
    HealthBenefits = "Rich in iron, supports healthy blood circulation.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 4,
    Name = "Salmon",
    Description = "206 calories.\r\n63 mg of cholesterol.\r\n22.1 g of protein.\r\n12.4 g of fat.\r\n0 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0 g of total sugars.\r\n",
    HealthBenefits = "Rich in omega-3 fatty acids, supports brain health.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 5,
    Name = "Pork Tenderloin",
    Description = "143 calories.\r\n62 mg of cholesterol.\r\n26.5 g of protein.\r\n3.7 g of fat.\r\n0 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0 g of total sugars.\r\n",
    HealthBenefits = "Good source of B-vitamins, helps in energy production.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 6,
    Name = "Mango",
    Description = "99 calories.\r\n0 mg of cholesterol.\r\n0.82 g of protein.\r\n0.38 g of fat.\r\n24.7 g of carbohydrate.\r\n2.6 g of dietary fiber.\r\n46.5 g of total sugars.\r\n",
    HealthBenefits = "High in vitamin C, boosts immune function.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 7,
    Name = "Banana",
    Description = "105 calories.\r\n0 mg of cholesterol.\r\n1.3 g of protein.\r\n0.3 g of fat.\r\n27 g of carbohydrate.\r\n3.1 g of dietary fiber.\r\n14.4 g of total sugars.\r\n",
    HealthBenefits = "High in potassium, supports heart health.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 8,
    Name = "Apple",
    Description = "95 calories.\r\n0 mg of cholesterol.\r\n0.5 g of protein.\r\n0.3 g of fat.\r\n25 g of carbohydrate.\r\n4.4 g of dietary fiber.\r\n19 g of total sugars.\r\n",
    HealthBenefits = "High in fiber, promotes digestive health.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 9,
    Name = "Orange",
    Description = "62 calories.\r\n0 mg of cholesterol.\r\n1.2 g of protein.\r\n0.2 g of fat.\r\n15.4 g of carbohydrate.\r\n3.1 g of dietary fiber.\r\n12.2 g of total sugars.\r\n",
    HealthBenefits = "Rich in vitamin C, supports immune system.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 10,
    Name = "Avocado",
    Description = "160 calories.\r\n0 mg of cholesterol.\r\n2 g of protein.\r\n15 g of fat.\r\n9 g of carbohydrate.\r\n7 g of dietary fiber.\r\n0.2 g of total sugars.\r\n",
    HealthBenefits = "Rich in healthy fats, promotes heart health.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 11,
    Name = "Strawberries",
    Description = "32 calories.\r\n0 mg of cholesterol.\r\n0.7 g of protein.\r\n0.3 g of fat.\r\n7.7 g of carbohydrate.\r\n2 g of dietary fiber.\r\n4.9 g of total sugars.\r\n",
    HealthBenefits = "Rich in antioxidants, supports skin health.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 12,
    Name = "Egg",
    Description = "68 calories.\r\n186 mg of cholesterol.\r\n5.5 g of protein.\r\n4.8 g of fat.\r\n0.6 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0.6 g of total sugars.\r\n",
    HealthBenefits = "High in protein, supports muscle repair and immune function.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 13,
    Name = "Sweet Potato",
    Description = "112 calories.\r\n0 mg of cholesterol.\r\n2.1 g of protein.\r\n0.1 g of fat.\r\n26.2 g of carbohydrate.\r\n3.9 g of dietary fiber.\r\n5.4 g of total sugars.\r\n",
    HealthBenefits = "High in vitamin A, promotes healthy vision.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 14,
    Name = "Tomato",
    Description = "22 calories.\r\n0 mg of cholesterol.\r\n1.1 g of protein.\r\n0.2 g of fat.\r\n4.8 g of carbohydrate.\r\n1.5 g of dietary fiber.\r\n3.2 g of total sugars.\r\n",
    HealthBenefits = "Rich in lycopene, supports heart health and reduces inflammation.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
},

new Macros
{
    Id = 15,
    Name = "Carrot",
    Description = "41 calories.\r\n0 mg of cholesterol.\r\n0.9 g of protein.\r\n0.2 g of fat.\r\n9.6 g of carbohydrate.\r\n2.8 g of dietary fiber.\r\n4.7 g of total sugars.\r\n",
    HealthBenefits = "High in vitamin A, supports healthy skin and vision.",
    DateCreated = DateTime.Now,
    DateUpdated = DateTime.Now,
}
);

        }


    }
}
