using Microsoft.EntityFrameworkCore.Migrations;

namespace RentAndGo.Migrations
{
    public partial class DodavanjeAtributa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "JMB",
                table: "BankovniRacun",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JMB",
                table: "BankovniRacun");
        }
    }
}
