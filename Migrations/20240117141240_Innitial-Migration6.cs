using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanca_Loredana_Madalina.Migrations
{
    /// <inheritdoc />
    public partial class InnitialMigration6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RolID",
                table: "Candidati",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Roluri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Companie = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DenumireRol = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Documente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roluri", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Candidati_RolID",
                table: "Candidati",
                column: "RolID",
                unique: true,
                filter: "[RolID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidati_Roluri_RolID",
                table: "Candidati",
                column: "RolID",
                principalTable: "Roluri",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidati_Roluri_RolID",
                table: "Candidati");

            migrationBuilder.DropTable(
                name: "Roluri");

            migrationBuilder.DropIndex(
                name: "IX_Candidati_RolID",
                table: "Candidati");

            migrationBuilder.DropColumn(
                name: "RolID",
                table: "Candidati");
        }
    }
}
