using Microsoft.EntityFrameworkCore.Migrations;

namespace RentAndGo.Migrations
{
    public partial class SlikaVozila : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SlikaVozila",
                table: "Vozilo",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlikaVozila",
                table: "Vozilo");
        }
    }
}
