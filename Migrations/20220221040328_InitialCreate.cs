using Microsoft.EntityFrameworkCore.Migrations;

namespace RazorPagesChess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Chess",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    quardLetter = table.Column<int>(type: "INTEGER", nullable: false),
                    quardNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    inCheck = table.Column<bool>(type: "INTEGER", nullable: false),
                    colour = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chess", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chess");
        }
    }
}
