using Microsoft.EntityFrameworkCore.Migrations;

namespace RentAndGo.Migrations
{
    public partial class Ispravka : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikSaNalogom_BankovniRacun_BankovniRacunBrojRacuna",
                table: "KorisnikSaNalogom");

            migrationBuilder.AlterColumn<string>(
                name: "BankovniRacunBrojRacuna",
                table: "KorisnikSaNalogom",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(767)");

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikSaNalogom_BankovniRacun_BankovniRacunBrojRacuna",
                table: "KorisnikSaNalogom",
                column: "BankovniRacunBrojRacuna",
                principalTable: "BankovniRacun",
                principalColumn: "BrojRacuna",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KorisnikSaNalogom_BankovniRacun_BankovniRacunBrojRacuna",
                table: "KorisnikSaNalogom");

            migrationBuilder.AlterColumn<string>(
                name: "BankovniRacunBrojRacuna",
                table: "KorisnikSaNalogom",
                type: "varchar(767)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisnikSaNalogom_BankovniRacun_BankovniRacunBrojRacuna",
                table: "KorisnikSaNalogom",
                column: "BankovniRacunBrojRacuna",
                principalTable: "BankovniRacun",
                principalColumn: "BrojRacuna",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
