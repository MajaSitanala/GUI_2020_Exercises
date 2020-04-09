using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab03.Data.Migrations
{
    public partial class InitialSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Illustrations",
                columns: table => new
                {
                    IllustrationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ThumbNailId = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Illustrations", x => x.IllustrationId);
                });

            migrationBuilder.CreateTable(
                name: "JoinApplications",
                columns: table => new
                {
                    JoinApplicationId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    Email = table.Column<string>(maxLength: 64, nullable: false),
                    Experience = table.Column<string>(maxLength: 2000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JoinApplications", x => x.JoinApplicationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Illustrations");

            migrationBuilder.DropTable(
                name: "JoinApplications");
        }
    }
}
