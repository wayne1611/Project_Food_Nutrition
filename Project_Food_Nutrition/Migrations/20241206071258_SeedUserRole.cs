using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project_Food_Nutrition.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(7929), new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(7949), new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8274), new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8276) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8278), new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8424), new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8426) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8428), new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8429) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8431), new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8434), new DateTime(2024, 12, 6, 15, 12, 57, 946, DateTimeKind.Local).AddTicks(8434) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(5888), new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(5902), new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6092), new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6092) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6094), new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6094) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6192), new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6193), new DateTime(2024, 12, 6, 15, 1, 9, 864, DateTimeKind.Local).AddTicks(6194) });
        }
    }
}
