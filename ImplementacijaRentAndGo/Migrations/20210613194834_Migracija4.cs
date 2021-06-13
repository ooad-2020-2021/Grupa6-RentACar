using Microsoft.EntityFrameworkCore.Migrations;

namespace ImplementacijaRentAndGo.Migrations
{
    public partial class Migracija4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "JMB",
                table: "BankovniRacun",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "JMB",
                table: "BankovniRacun",
                type: "int",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
