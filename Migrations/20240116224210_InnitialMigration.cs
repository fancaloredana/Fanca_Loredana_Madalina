using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanca_Loredana_Madalina.Migrations
{
    /// <inheritdoc />
    public partial class InnitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidati",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Prenume = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    GDPR = table.Column<bool>(type: "bit", nullable: false),
                    Documente = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidati", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "StudiiSuperioare",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Facultate = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Specializare = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudiiSuperioare", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ResurseUmane",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nume_Prenume = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Functie = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Numar_Telefon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StudiiSuperioareID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResurseUmane", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ResurseUmane_StudiiSuperioare_StudiiSuperioareID",
                        column: x => x.StudiiSuperioareID,
                        principalTable: "StudiiSuperioare",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CandidatiResurseUmane",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ResurseUmaneID = table.Column<int>(type: "int", nullable: false),
                    CandidatiID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidatiResurseUmane", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CandidatiResurseUmane_Candidati_CandidatiID",
                        column: x => x.CandidatiID,
                        principalTable: "Candidati",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidatiResurseUmane_ResurseUmane_ResurseUmaneID",
                        column: x => x.ResurseUmaneID,
                        principalTable: "ResurseUmane",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidatiResurseUmane_CandidatiID",
                table: "CandidatiResurseUmane",
                column: "CandidatiID");

            migrationBuilder.CreateIndex(
                name: "IX_CandidatiResurseUmane_ResurseUmaneID",
                table: "CandidatiResurseUmane",
                column: "ResurseUmaneID");

            migrationBuilder.CreateIndex(
                name: "IX_ResurseUmane_StudiiSuperioareID",
                table: "ResurseUmane",
                column: "StudiiSuperioareID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidatiResurseUmane");

            migrationBuilder.DropTable(
                name: "Candidati");

            migrationBuilder.DropTable(
                name: "ResurseUmane");

            migrationBuilder.DropTable(
                name: "StudiiSuperioare");
        }
    }
}
