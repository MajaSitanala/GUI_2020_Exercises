using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab01.Data.Migrations
{
    public partial class Initial03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Illustration",
                table: "Illustration");

            migrationBuilder.RenameTable(
                name: "Illustration",
                newName: "Illustrations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Illustrations",
                table: "Illustrations",
                column: "IllustrationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Illustrations",
                table: "Illustrations");

            migrationBuilder.RenameTable(
                name: "Illustrations",
                newName: "Illustration");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Illustration",
                table: "Illustration",
                column: "IllustrationId");
        }
    }
}
