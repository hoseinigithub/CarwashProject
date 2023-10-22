using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarwashProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Khadamat2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Khadamats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Door", 80000m });

            migrationBuilder.UpdateData(
                table: "Khadamats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Dashboard", 80000m });

            migrationBuilder.UpdateData(
                table: "Khadamats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Ceiling", 80000m });

            migrationBuilder.UpdateData(
                table: "Khadamats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Column", 60000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Khadamats",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Roshoei", 60000m });

            migrationBuilder.UpdateData(
                table: "Khadamats",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Broom", 40000m });

            migrationBuilder.UpdateData(
                table: "Khadamats",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Wax", 50000m });

            migrationBuilder.UpdateData(
                table: "Khadamats",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Enginewash", 80000m });
        }
    }
}
