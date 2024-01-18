using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fanca_Loredana_Madalina.Migrations
{
    /// <inheritdoc />
    public partial class InnitialMigration10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResurseUmane_StudiiSuperioare_StudiiSuperioareID",
                table: "ResurseUmane");

            migrationBuilder.AlterColumn<int>(
                name: "StudiiSuperioareID",
                table: "ResurseUmane",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ResurseUmane_StudiiSuperioare_StudiiSuperioareID",
                table: "ResurseUmane",
                column: "StudiiSuperioareID",
                principalTable: "StudiiSuperioare",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ResurseUmane_StudiiSuperioare_StudiiSuperioareID",
                table: "ResurseUmane");

            migrationBuilder.AlterColumn<int>(
                name: "StudiiSuperioareID",
                table: "ResurseUmane",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ResurseUmane_StudiiSuperioare_StudiiSuperioareID",
                table: "ResurseUmane",
                column: "StudiiSuperioareID",
                principalTable: "StudiiSuperioare",
                principalColumn: "ID");
        }
    }
}
