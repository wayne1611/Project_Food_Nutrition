using Project_Food_Nutrition.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Project_Food_Nutrition.Configurations.Entities
{
    public class RecipeSeed : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder.HasData(
                new Recipe
                {
                    Id = 1,
                    Name = "Simple Salad",
                    Ingredients = "Lettuce, Tomato, Cucumber, Olive Oil, Salt, Pepper",
                    Instructions = "1. Chop the lettuce, tomato, and cucumber.\n2. Mix the ingredients in a bowl.\n3. Add olive oil, salt, and pepper to taste.\n4. Toss and serve.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Recipe
                {
                    Id = 2,
                    Name = "Scrambled Eggs",
                    Ingredients = "Eggs, Butter, Salt, Pepper",
                    Instructions = "1. Crack the eggs into a bowl.\n2. Whisk with a fork.\n3. Heat butter in a pan.\n4. Pour in eggs and stir until cooked.\n5. Add salt and pepper to taste.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Recipe
                {
                    Id = 3,
                    Name = "Pasta Aglio e Olio",
                    Ingredients = "Spaghetti, Garlic, Olive Oil, Red Pepper Flakes, Parsley, Salt",
                    Instructions = "1. Boil pasta in salted water until al dente.\n2. In a pan, heat olive oil and sauté garlic until golden.\n3. Add red pepper flakes.\n4. Toss pasta with garlic and oil.\n5. Garnish with parsley and serve.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Recipe
                {
                    Id = 4,
                    Name = "Grilled Cheese Sandwich",
                    Ingredients = "Bread, Cheese, Butter",
                    Instructions = "1. Butter both sides of two slices of bread.\n2. Place cheese between the slices.\n3. Grill on medium heat until both sides are golden brown.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Recipe
                {
                    Id = 5,
                    Name = "Tomato Soup",
                    Ingredients = "Tomatoes, Onion, Garlic, Olive Oil, Salt, Pepper, Water",
                    Instructions = "1. Sauté onion and garlic in olive oil.\n2. Add chopped tomatoes and cook until soft.\n3. Add water and simmer.\n4. Blend the soup and season with salt and pepper.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Recipe
                {
                    Id = 6,
                    Name = "Fruit Smoothie",
                    Ingredients = "Banana, Strawberries, Milk, Honey",
                    Instructions = "1. Add all ingredients into a blender.\n2. Blend until smooth.\n3. Serve chilled.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Recipe
                {
                    Id = 7,
                    Name = "Omelette",
                    Ingredients = "Eggs, Milk, Salt, Pepper, Butter",
                    Instructions = "1. Whisk eggs with milk, salt, and pepper.\n2. Heat butter in a pan.\n3. Pour in the egg mixture and cook until set.\n4. Fold and serve.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Recipe
                {
                    Id = 8,
                    Name = "Chicken Stir-fry",
                    Ingredients = "Chicken Breast, Bell Peppers, Soy Sauce, Garlic, Ginger",
                    Instructions = "1. Slice chicken and bell peppers.\n2. Stir-fry garlic and ginger in a pan.\n3. Add chicken and cook until browned.\n4. Add bell peppers and soy sauce, stir-fry until cooked.",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                }
            );
        }
    }
}
