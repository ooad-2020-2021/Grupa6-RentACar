using Microsoft.EntityFrameworkCore.Migrations;

namespace ImplementacijaRentAndGo.Migrations
{
    public partial class SlikaVozaca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SlikaVozaca",
                table: "Vozac",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlikaVozaca",
                table: "Vozac");
        }
    }
}
