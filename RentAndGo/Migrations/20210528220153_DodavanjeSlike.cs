using Microsoft.EntityFrameworkCore.Migrations;

namespace RentAndGo.Migrations
{
    public partial class DodavanjeSlike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SlikaKorisnika",
                table: "KorisnikSaNalogom",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlikaKorisnika",
                table: "KorisnikSaNalogom");
        }
    }
}
