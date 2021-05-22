using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace RentAndGo.Migrations
{
    public partial class MigracijaRentAndGo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admin",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(nullable: false),
                    Lozinka = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BankovniRacun",
                columns: table => new
                {
                    BrojRacuna = table.Column<string>(nullable: false),
                    DatumValidnostiKartice = table.Column<DateTime>(nullable: false),
                    ImePrezime = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankovniRacun", x => x.BrojRacuna);
                });

            migrationBuilder.CreateTable(
                name: "Iznajmljivanje",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    IDKlijenta = table.Column<int>(nullable: false),
                    IDVozila = table.Column<int>(nullable: false),
                    IDVozaca = table.Column<int>(nullable: false),
                    IDAdmin = table.Column<int>(nullable: false),
                    Cijena = table.Column<double>(nullable: false),
                    Lokacija = table.Column<string>(nullable: false),
                    Stanje = table.Column<int>(nullable: false),
                    Komentar = table.Column<string>(nullable: true),
                    Popust = table.Column<int>(nullable: false),
                    NacinPlacanja = table.Column<string>(nullable: false),
                    DatumPreuzmanja = table.Column<DateTime>(nullable: false),
                    DatumVracanja = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iznajmljivanje", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Vozac",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    BrojTelefona = table.Column<string>(nullable: false),
                    BrojVozackeDozvole = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozac", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VozackaDozvola",
                columns: table => new
                {
                    BrojVozackeDozvole = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    NadlezniOrgan = table.Column<string>(nullable: false),
                    Kategorija = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VozackaDozvola", x => x.BrojVozackeDozvole);
                });

            migrationBuilder.CreateTable(
                name: "Vozilo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: false),
                    Gorivo = table.Column<int>(nullable: false),
                    Klasa = table.Column<int>(nullable: false),
                    Mjenjac = table.Column<int>(nullable: false),
                    MaksimalanBrojPutnika = table.Column<int>(nullable: false),
                    CijenaPoDanu = table.Column<int>(nullable: false),
                    DatumTehnickogPregleda = table.Column<DateTime>(nullable: false),
                    BrojRegistacijskihTablica = table.Column<string>(nullable: false),
                    Klima = table.Column<bool>(nullable: false),
                    SistemBezKljuca = table.Column<bool>(nullable: false),
                    AluminijskeFelge = table.Column<bool>(nullable: false),
                    SklopiviRetrovizori = table.Column<bool>(nullable: false),
                    BoardComputer = table.Column<bool>(nullable: false),
                    MP3Interfejs = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozilo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikSaNalogom",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    Prezime = table.Column<string>(nullable: false),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Lozinka = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    BrojTelefona = table.Column<string>(nullable: false),
                    BankovniRacunBrojRacuna = table.Column<string>(nullable: false),
                    BrojVozackeDozvole = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikSaNalogom", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KorisnikSaNalogom_BankovniRacun_BankovniRacunBrojRacuna",
                        column: x => x.BankovniRacunBrojRacuna,
                        principalTable: "BankovniRacun",
                        principalColumn: "BrojRacuna",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikSaNalogom_BankovniRacunBrojRacuna",
                table: "KorisnikSaNalogom",
                column: "BankovniRacunBrojRacuna");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admin");

            migrationBuilder.DropTable(
                name: "Iznajmljivanje");

            migrationBuilder.DropTable(
                name: "KorisnikSaNalogom");

            migrationBuilder.DropTable(
                name: "Vozac");

            migrationBuilder.DropTable(
                name: "VozackaDozvola");

            migrationBuilder.DropTable(
                name: "Vozilo");

            migrationBuilder.DropTable(
                name: "BankovniRacun");
        }
    }
}
