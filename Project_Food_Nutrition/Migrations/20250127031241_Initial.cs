using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_Food_Nutrition.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CalorieProgress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetCalories = table.Column<int>(type: "int", nullable: false),
                    TotalCalories = table.Column<int>(type: "int", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CalorieProgress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoggedCalories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaloriesCount = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoggedCalories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MacrosTracking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Calories = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Carbohydrates = table.Column<double>(type: "float", nullable: false),
                    Fats = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MacrosTracking", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Macros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthBenefits = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Macros_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDietName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DailyCaloriesRecommend = table.Column<int>(type: "int", nullable: false),
                    CurrentCalories = table.Column<int>(type: "int", nullable: false),
                    CaloriesDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaloriesTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Recipe_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Calorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaloriesCount = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calorie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calorie_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MacrosName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MacrosValue = table.Column<int>(type: "int", nullable: false),
                    MacrosTrackingId = table.Column<int>(type: "int", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Staff_MacrosTracking_MacrosTrackingId",
                        column: x => x.MacrosTrackingId,
                        principalTable: "MacrosTracking",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Staff_User_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Calorie",
                columns: new[] { "Id", "CaloriesCount", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy", "UserId", "UserName" },
                values: new object[,]
                {
                    { 1, 750, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3574), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3597), "Chicken Salad", "System", null, 0 },
                    { 2, 400, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3603), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3604), "Grilled Chicken Sandwich", "System", null, 0 },
                    { 3, 250, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3605), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3606), "Avocado Toast with egg ", "System", null, 0 },
                    { 4, 600, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3608), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3609), "Spaghetti Bolognese (1 plate)", "System", null, 0 },
                    { 5, 450, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3610), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3611), "Grilled salmon with quinoa and vegetables (1 plate)", "System", null, 0 },
                    { 6, 200, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3612), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3613), "Apple slices with peanut butter (1 serving)", "System", null, 0 },
                    { 7, 100, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3615), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3615), "Chocolate chip cookies (1 cookie)", "System", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Macros",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Description", "HealthBenefits", "Name", "RecipeId", "UpdatedBy" },
                values: new object[,]
                {
                    { 2, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4091), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4091), "165 calories.\r\n3.6 g of cholesterol.\r\n31 g of protein.\r\n3.6 g of fat.\r\n0 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0 g of total sugars.\r\n", "High in protein, promotes muscle growth and repair.", "Chicken Breast", null, null },
                    { 3, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4093), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4093), "242 calories.\r\n78 mg of cholesterol.\r\n22.8 g of protein.\r\n16.3 g of fat.\r\n0 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0 g of total sugars.\r\n", "Rich in iron, supports healthy blood circulation.", "Beef Steak", null, null },
                    { 4, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4095), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4096), "206 calories.\r\n63 mg of cholesterol.\r\n22.1 g of protein.\r\n12.4 g of fat.\r\n0 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0 g of total sugars.\r\n", "Rich in omega-3 fatty acids, supports brain health.", "Salmon", null, null },
                    { 5, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4097), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4097), "143 calories.\r\n62 mg of cholesterol.\r\n26.5 g of protein.\r\n3.7 g of fat.\r\n0 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0 g of total sugars.\r\n", "Good source of B-vitamins, helps in energy production.", "Pork Tenderloin", null, null },
                    { 6, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4099), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4099), "99 calories.\r\n0 mg of cholesterol.\r\n0.82 g of protein.\r\n0.38 g of fat.\r\n24.7 g of carbohydrate.\r\n2.6 g of dietary fiber.\r\n46.5 g of total sugars.\r\n", "High in vitamin C, boosts immune function.", "Mango", null, null },
                    { 7, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4100), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4101), "105 calories.\r\n0 mg of cholesterol.\r\n1.3 g of protein.\r\n0.3 g of fat.\r\n27 g of carbohydrate.\r\n3.1 g of dietary fiber.\r\n14.4 g of total sugars.\r\n", "High in potassium, supports heart health.", "Banana", null, null },
                    { 8, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4102), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4102), "95 calories.\r\n0 mg of cholesterol.\r\n0.5 g of protein.\r\n0.3 g of fat.\r\n25 g of carbohydrate.\r\n4.4 g of dietary fiber.\r\n19 g of total sugars.\r\n", "High in fiber, promotes digestive health.", "Apple", null, null },
                    { 9, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4104), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4104), "62 calories.\r\n0 mg of cholesterol.\r\n1.2 g of protein.\r\n0.2 g of fat.\r\n15.4 g of carbohydrate.\r\n3.1 g of dietary fiber.\r\n12.2 g of total sugars.\r\n", "Rich in vitamin C, supports immune system.", "Orange", null, null },
                    { 10, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4106), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4106), "160 calories.\r\n0 mg of cholesterol.\r\n2 g of protein.\r\n15 g of fat.\r\n9 g of carbohydrate.\r\n7 g of dietary fiber.\r\n0.2 g of total sugars.\r\n", "Rich in healthy fats, promotes heart health.", "Avocado", null, null },
                    { 11, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4107), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4108), "32 calories.\r\n0 mg of cholesterol.\r\n0.7 g of protein.\r\n0.3 g of fat.\r\n7.7 g of carbohydrate.\r\n2 g of dietary fiber.\r\n4.9 g of total sugars.\r\n", "Rich in antioxidants, supports skin health.", "Strawberries", null, null },
                    { 12, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4109), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4109), "68 calories.\r\n186 mg of cholesterol.\r\n5.5 g of protein.\r\n4.8 g of fat.\r\n0.6 g of carbohydrate.\r\n0 g of dietary fiber.\r\n0.6 g of total sugars.\r\n", "High in protein, supports muscle repair and immune function.", "Egg", null, null },
                    { 13, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4111), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4111), "112 calories.\r\n0 mg of cholesterol.\r\n2.1 g of protein.\r\n0.1 g of fat.\r\n26.2 g of carbohydrate.\r\n3.9 g of dietary fiber.\r\n5.4 g of total sugars.\r\n", "High in vitamin A, promotes healthy vision.", "Sweet Potato", null, null },
                    { 14, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4113), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4113), "22 calories.\r\n0 mg of cholesterol.\r\n1.1 g of protein.\r\n0.2 g of fat.\r\n4.8 g of carbohydrate.\r\n1.5 g of dietary fiber.\r\n3.2 g of total sugars.\r\n", "Rich in lycopene, supports heart health and reduces inflammation.", "Tomato", null, null },
                    { 15, null, new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4114), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(4115), "41 calories.\r\n0 mg of cholesterol.\r\n0.9 g of protein.\r\n0.2 g of fat.\r\n9.6 g of carbohydrate.\r\n2.8 g of dietary fiber.\r\n4.7 g of total sugars.\r\n", "High in vitamin A, supports healthy skin and vision.", "Carrot", null, null }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Ingredients", "Instructions", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3883), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3884), "Lettuce, Tomato, Cucumber, Olive Oil, Salt, Pepper", "1. Chop the lettuce, tomato, and cucumber.\n2. Mix the ingredients in a bowl.\n3. Add olive oil, salt, and pepper to taste.\n4. Toss and serve.", "Simple Salad", "System" },
                    { 2, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3886), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3886), "Eggs, Butter, Salt, Pepper", "1. Crack the eggs into a bowl.\n2. Whisk with a fork.\n3. Heat butter in a pan.\n4. Pour in eggs and stir until cooked.\n5. Add salt and pepper to taste.", "Scrambled Eggs", "System" },
                    { 3, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3888), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3888), "Spaghetti, Garlic, Olive Oil, Red Pepper Flakes, Parsley, Salt", "1. Boil pasta in salted water until al dente.\n2. In a pan, heat olive oil and sauté garlic until golden.\n3. Add red pepper flakes.\n4. Toss pasta with garlic and oil.\n5. Garnish with parsley and serve.", "Pasta Aglio e Olio", "System" },
                    { 4, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3890), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3890), "Bread, Cheese, Butter", "1. Butter both sides of two slices of bread.\n2. Place cheese between the slices.\n3. Grill on medium heat until both sides are golden brown.", "Grilled Cheese Sandwich", "System" },
                    { 5, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3892), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3892), "Tomatoes, Onion, Garlic, Olive Oil, Salt, Pepper, Water", "1. Sauté onion and garlic in olive oil.\n2. Add chopped tomatoes and cook until soft.\n3. Add water and simmer.\n4. Blend the soup and season with salt and pepper.", "Tomato Soup", "System" },
                    { 6, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3893), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3894), "Banana, Strawberries, Milk, Honey", "1. Add all ingredients into a blender.\n2. Blend until smooth.\n3. Serve chilled.", "Fruit Smoothie", "System" },
                    { 7, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3895), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3896), "Eggs, Milk, Salt, Pepper, Butter", "1. Whisk eggs with milk, salt, and pepper.\n2. Heat butter in a pan.\n3. Pour in the egg mixture and cook until set.\n4. Fold and serve.", "Omelette", "System" },
                    { 8, "System", new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3897), new DateTime(2025, 1, 27, 11, 12, 40, 545, DateTimeKind.Local).AddTicks(3898), "Chicken Breast, Bell Peppers, Soy Sauce, Garlic, Ginger", "1. Slice chicken and bell peppers.\n2. Stir-fry garlic and ginger in a pan.\n3. Add chicken and cook until browned.\n4. Add bell peppers and soy sauce, stir-fry until cooked.", "Chicken Stir-fry", "System" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Calorie_UserId",
                table: "Calorie",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Macros_RecipeId",
                table: "Macros",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_CustomerId",
                table: "Staff",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Staff_MacrosTrackingId",
                table: "Staff",
                column: "MacrosTrackingId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RecipeId",
                table: "User",
                column: "RecipeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Calorie");

            migrationBuilder.DropTable(
                name: "CalorieProgress");

            migrationBuilder.DropTable(
                name: "LoggedCalories");

            migrationBuilder.DropTable(
                name: "Macros");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MacrosTracking");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Recipe");
        }
    }
}
