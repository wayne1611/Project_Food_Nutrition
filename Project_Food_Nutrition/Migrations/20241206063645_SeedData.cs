using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project_Food_Nutrition.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(4920), new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(4932), "Black", "System" },
                    { 2, "System", new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(4933), new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(4934), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5141), new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5142), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5143), new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5144), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5281), new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5282), "i4", "System" },
                    { 2, "System", new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5284), new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5285), "X5", "System" },
                    { 3, "System", new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5286), new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5286), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5287), new DateTime(2024, 12, 6, 14, 36, 44, 964, DateTimeKind.Local).AddTicks(5288), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
