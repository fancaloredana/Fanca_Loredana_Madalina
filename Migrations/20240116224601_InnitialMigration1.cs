using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanca_Loredana_Madalina.Migrations
{
    /// <inheritdoc />
    public partial class InnitialMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidatiID",
                table: "ResurseUmane",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ResurseUmane_CandidatiID",
                table: "ResurseUmane",
                column: "CandidatiID");

            migrationBuilder.AddForeignKey(
                name: "FK_ResurseUmane_Candidati_CandidatiID",
                table: "ResurseUmane",
                column: "CandidatiID",
                principalTable: "Candidati",
                principalColumn: "ID",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResurseUmane_Candidati_CandidatiID",
                table: "ResurseUmane");

            migrationBuilder.DropIndex(
                name: "IX_ResurseUmane_CandidatiID",
                table: "ResurseUmane");

            migrationBuilder.DropColumn(
                name: "CandidatiID",
                table: "ResurseUmane");
        }
    }
}
