using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarwashProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class newKhadamat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkerInService");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.CreateTable(
                name: "Khadamats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khadamats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkerInKhadamat",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkerId = table.Column<int>(type: "int", nullable: false),
                    KhadamatId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerInKhadamat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkerInKhadamat_Khadamats_KhadamatId",
                        column: x => x.KhadamatId,
                        principalTable: "Khadamats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerInKhadamat_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Khadamats",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Roshoei", 60000m },
                    { 2, "Broom", 40000m },
                    { 3, "Wax", 50000m },
                    { 4, "Enginewash", 80000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerInKhadamat_KhadamatId",
                table: "WorkerInKhadamat",
                column: "KhadamatId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerInKhadamat_WorkerId",
                table: "WorkerInKhadamat",
                column: "WorkerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkerInKhadamat");

            migrationBuilder.DropTable(
                name: "Khadamats");

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkerInService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    WorkerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkerInService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkerInService_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WorkerInService_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkerInService_ServiceId",
                table: "WorkerInService",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkerInService_WorkerId",
                table: "WorkerInService",
                column: "WorkerId");
        }
    }
}
