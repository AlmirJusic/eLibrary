using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Migrations
{
    public partial class Inicijalna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    Drzava_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivDrzave = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.Drzava_ID);
                });

            migrationBuilder.CreateTable(
                name: "Knjiga",
                columns: table => new
                {
                    Knjiga_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKnjige = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumIzdavanja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Slika = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Cijena = table.Column<double>(type: "float", nullable: false),
                    Ocjena = table.Column<double>(type: "float", nullable: false),
                    PDF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PDFDodan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knjiga", x => x.Knjiga_ID);
                });

            migrationBuilder.CreateTable(
                name: "NacinPlacanja",
                columns: table => new
                {
                    NacinPlacanja_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NacinPlacanja", x => x.NacinPlacanja_ID);
                });

            migrationBuilder.CreateTable(
                name: "Spol",
                columns: table => new
                {
                    Spol_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OznakaSpola = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spol", x => x.Spol_ID);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    Uloga_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivUloge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.Uloga_ID);
                });

            migrationBuilder.CreateTable(
                name: "Zanr",
                columns: table => new
                {
                    Zanr_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivZanra = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanr", x => x.Zanr_ID);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    Grad_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivGrada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Drzava_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.Grad_ID);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_Drzava_ID",
                        column: x => x.Drzava_ID,
                        principalTable: "Drzava",
                        principalColumn: "Drzava_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Placanje",
                columns: table => new
                {
                    Placanje_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UkupnaCijena = table.Column<double>(type: "float", nullable: false),
                    NacinPlacanja_ID = table.Column<int>(type: "int", nullable: false),
                    ImePrezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojKreditneKartice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CVV = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumPlacanja = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Placanje", x => x.Placanje_ID);
                    table.ForeignKey(
                        name: "FK_Placanje_NacinPlacanja_NacinPlacanja_ID",
                        column: x => x.NacinPlacanja_ID,
                        principalTable: "NacinPlacanja",
                        principalColumn: "NacinPlacanja_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KnjigaZanr",
                columns: table => new
                {
                    KnjigaZanr_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Knjiga_ID = table.Column<int>(type: "int", nullable: false),
                    Zanr_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnjigaZanr", x => x.KnjigaZanr_ID);
                    table.ForeignKey(
                        name: "FK_KnjigaZanr_Knjiga_Knjiga_ID",
                        column: x => x.Knjiga_ID,
                        principalTable: "Knjiga",
                        principalColumn: "Knjiga_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnjigaZanr_Zanr_Zanr_ID",
                        column: x => x.Zanr_ID,
                        principalTable: "Zanr",
                        principalColumn: "Zanr_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    Korisnik_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Spol_ID = table.Column<int>(type: "int", nullable: false),
                    Grad_ID = table.Column<int>(type: "int", nullable: false),
                    Uloga_ID = table.Column<int>(type: "int", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.Korisnik_ID);
                    table.ForeignKey(
                        name: "FK_Korisnik_Grad_Grad_ID",
                        column: x => x.Grad_ID,
                        principalTable: "Grad",
                        principalColumn: "Grad_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korisnik_Spol_Spol_ID",
                        column: x => x.Spol_ID,
                        principalTable: "Spol",
                        principalColumn: "Spol_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Korisnik_Uloga_Uloga_ID",
                        column: x => x.Uloga_ID,
                        principalTable: "Uloga",
                        principalColumn: "Uloga_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pisac",
                columns: table => new
                {
                    Pisac_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Grad_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pisac", x => x.Pisac_ID);
                    table.ForeignKey(
                        name: "FK_Pisac_Grad_Grad_ID",
                        column: x => x.Grad_ID,
                        principalTable: "Grad",
                        principalColumn: "Grad_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikKnjigaKomentar",
                columns: table => new
                {
                    Komentar_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SadrzajKomentara = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumKomentara = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Korisnik_ID = table.Column<int>(type: "int", nullable: false),
                    Knjiga_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikKnjigaKomentar", x => x.Komentar_ID);
                    table.ForeignKey(
                        name: "FK_KorisnikKnjigaKomentar_Knjiga_Knjiga_ID",
                        column: x => x.Knjiga_ID,
                        principalTable: "Knjiga",
                        principalColumn: "Knjiga_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikKnjigaKomentar_Korisnik_Korisnik_ID",
                        column: x => x.Korisnik_ID,
                        principalTable: "Korisnik",
                        principalColumn: "Korisnik_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KorisnikKnjigaOcjena",
                columns: table => new
                {
                    KorisnikKnjigaOcjena_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<double>(type: "float", nullable: false),
                    DatumOcjene = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Korisnik_ID = table.Column<int>(type: "int", nullable: false),
                    Knjiga_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikKnjigaOcjena", x => x.KorisnikKnjigaOcjena_ID);
                    table.ForeignKey(
                        name: "FK_KorisnikKnjigaOcjena_Knjiga_Knjiga_ID",
                        column: x => x.Knjiga_ID,
                        principalTable: "Knjiga",
                        principalColumn: "Knjiga_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KorisnikKnjigaOcjena_Korisnik_Korisnik_ID",
                        column: x => x.Korisnik_ID,
                        principalTable: "Korisnik",
                        principalColumn: "Korisnik_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KupovinaKnjige",
                columns: table => new
                {
                    KupovinaKnjige_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DatumKupovine = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Korisnik_ID = table.Column<int>(type: "int", nullable: false),
                    Knjiga_ID = table.Column<int>(type: "int", nullable: false),
                    Placanje_ID = table.Column<int>(type: "int", nullable: false),
                    Odobreno = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KupovinaKnjige", x => x.KupovinaKnjige_ID);
                    table.ForeignKey(
                        name: "FK_KupovinaKnjige_Knjiga_Knjiga_ID",
                        column: x => x.Knjiga_ID,
                        principalTable: "Knjiga",
                        principalColumn: "Knjiga_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KupovinaKnjige_Korisnik_Korisnik_ID",
                        column: x => x.Korisnik_ID,
                        principalTable: "Korisnik",
                        principalColumn: "Korisnik_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KupovinaKnjige_Placanje_Placanje_ID",
                        column: x => x.Placanje_ID,
                        principalTable: "Placanje",
                        principalColumn: "Placanje_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrijedlogKnjige",
                columns: table => new
                {
                    PrijedlogKnjige_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivPrijedlogaKnjige = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumPrijedloga = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Odgovoren = table.Column<bool>(type: "bit", nullable: false),
                    Pregledan = table.Column<bool>(type: "bit", nullable: false),
                    Korisnik_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrijedlogKnjige", x => x.PrijedlogKnjige_ID);
                    table.ForeignKey(
                        name: "FK_PrijedlogKnjige_Korisnik_Korisnik_ID",
                        column: x => x.Korisnik_ID,
                        principalTable: "Korisnik",
                        principalColumn: "Korisnik_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KnjigaPisac",
                columns: table => new
                {
                    KnjigaPisac_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Knjiga_ID = table.Column<int>(type: "int", nullable: false),
                    Pisac_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnjigaPisac", x => x.KnjigaPisac_ID);
                    table.ForeignKey(
                        name: "FK_KnjigaPisac_Knjiga_Knjiga_ID",
                        column: x => x.Knjiga_ID,
                        principalTable: "Knjiga",
                        principalColumn: "Knjiga_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnjigaPisac_Pisac_Pisac_ID",
                        column: x => x.Pisac_ID,
                        principalTable: "Pisac",
                        principalColumn: "Pisac_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Drzava",
                columns: new[] { "Drzava_ID", "NazivDrzave" },
                values: new object[,]
                {
                    { 1, "Bosna i Hercegovina" },
                    { 2, "Hrvatska" },
                    { 3, "Turska" },
                    { 4, "Spanija" }
                });

            migrationBuilder.InsertData(
                table: "Knjiga",
                columns: new[] { "Knjiga_ID", "Cijena", "DatumIzdavanja", "NazivKnjige", "Ocjena", "Opis", "PDF", "PDFDodan", "Slika" },
                values: new object[,]
                {
                    { 1, 49.990000000000002, new DateTime(2022, 1, 6, 11, 40, 45, 560, DateTimeKind.Local).AddTicks(9003), "Na Drini cuprija", 5.0, "Priča počinje s uvjetima života u Višegradu prije nego što je most sagrađen, a onda se nastavlja na njegovu izgradnju u 16. stoljeću. Nakon toga govori o životu u kasabi koji je usko vezan uz most. Preko njega prolaze putnici, trgovci i mještani. Svaki veliki događaj, bio sretan ili ne, obilježava se prelaskom preko mosta. ", "NaDrinicuprija.pdf", true, null },
                    { 2, 39.990000000000002, new DateTime(2022, 1, 6, 11, 40, 45, 560, DateTimeKind.Local).AddTicks(9706), "Dnevnik Ane Frank", 4.7000000000000002, "Annin dnevnik pisan je u vremenskom razdoblju od 1942 do 1944. godine, najteža vremena Drugog svjetskog rata u Europi. Kamo god krenuli, Hitlerova je vojska širila otrov antisemitizma i rasne mržnje. ", "DnevnikAneFrank.pdf", true, null },
                    { 3, 10.0, new DateTime(2022, 1, 6, 11, 40, 45, 560, DateTimeKind.Local).AddTicks(9727), "Pjesme", 4.4000000000000004, "Ovo su pjesme Sidran Abdulaha ", "PJesme-Abdulah-Sidran.pdf", true, null }
                });

            migrationBuilder.InsertData(
                table: "NacinPlacanja",
                columns: new[] { "NacinPlacanja_ID", "Naziv" },
                values: new object[,]
                {
                    { 2, "PayPal" },
                    { 1, "Placanje bankovnom karticom." }
                });

            migrationBuilder.InsertData(
                table: "Spol",
                columns: new[] { "Spol_ID", "OznakaSpola" },
                values: new object[,]
                {
                    { 1, "M" },
                    { 2, "Ž" }
                });

            migrationBuilder.InsertData(
                table: "Uloga",
                columns: new[] { "Uloga_ID", "NazivUloge", "Opis" },
                values: new object[,]
                {
                    { 1, "Administrator", "Ovaj uloga je administrator!" },
                    { 2, "Korisnik", "Ovaj uloga je obicni korisnik!" }
                });

            migrationBuilder.InsertData(
                table: "Zanr",
                columns: new[] { "Zanr_ID", "NazivZanra" },
                values: new object[,]
                {
                    { 3, "Novela" },
                    { 1, "Horor" },
                    { 2, "Romantika" },
                    { 4, "Naucna Fantastika" }
                });

            migrationBuilder.InsertData(
                table: "Grad",
                columns: new[] { "Grad_ID", "Drzava_ID", "NazivGrada" },
                values: new object[,]
                {
                    { 1, 1, "Sarajevo" },
                    { 2, 2, "Zagreb" },
                    { 3, 3, "Ankara" },
                    { 4, 4, "Barselona" }
                });

            migrationBuilder.InsertData(
                table: "KnjigaZanr",
                columns: new[] { "KnjigaZanr_ID", "Knjiga_ID", "Zanr_ID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 3, 2 },
                    { 2, 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "Placanje",
                columns: new[] { "Placanje_ID", "BrojKreditneKartice", "CVV", "DatumPlacanja", "ImePrezime", "NacinPlacanja_ID", "UkupnaCijena" },
                values: new object[,]
                {
                    { 2, "1234555522223333", "123", new DateTime(2022, 1, 6, 11, 40, 45, 566, DateTimeKind.Local).AddTicks(9385), "Almir Jusic", 1, 25.0 },
                    { 4, "1111222233334444", "999", new DateTime(2022, 1, 6, 11, 40, 45, 567, DateTimeKind.Local).AddTicks(753), "Meho Mehic", 1, 25.0 },
                    { 1, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 49.990000000000002 },
                    { 3, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 21.5 }
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "Korisnik_ID", "DatumRodjenja", "Email", "Grad_ID", "Ime", "PasswordHash", "PasswordSalt", "Prezime", "Spol_ID", "Uloga_ID", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 6, 11, 40, 45, 559, DateTimeKind.Local).AddTicks(1865), "admin@gmail.com", 1, "Admin", "/", "/", "Admin", 1, 1, "admin" },
                    { 2, new DateTime(2022, 1, 6, 11, 40, 45, 559, DateTimeKind.Local).AddTicks(7587), "almirjusic@edu.fit.ba", 2, "Almir", "/", "/", "Jusic", 1, 2, "almirjusic" }
                });

            migrationBuilder.InsertData(
                table: "Pisac",
                columns: new[] { "Pisac_ID", "DatumRodjenja", "Grad_ID", "Ime", "Prezime" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 6, 11, 40, 45, 552, DateTimeKind.Local).AddTicks(2509), 1, "Abdulah", "Sidran" },
                    { 4, new DateTime(2022, 1, 6, 11, 40, 45, 557, DateTimeKind.Local).AddTicks(3123), 2, "Ana", "Frank" },
                    { 3, new DateTime(2022, 1, 6, 11, 40, 45, 557, DateTimeKind.Local).AddTicks(3115), 3, "Mak", "Dizdar" },
                    { 2, new DateTime(2022, 1, 6, 11, 40, 45, 557, DateTimeKind.Local).AddTicks(3062), 4, "Ivo", "Andric" }
                });

            migrationBuilder.InsertData(
                table: "KnjigaPisac",
                columns: new[] { "KnjigaPisac_ID", "Knjiga_ID", "Pisac_ID" },
                values: new object[,]
                {
                    { 3, 3, 1 },
                    { 2, 2, 4 },
                    { 1, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "KorisnikKnjigaKomentar",
                columns: new[] { "Komentar_ID", "DatumKomentara", "Knjiga_ID", "Korisnik_ID", "SadrzajKomentara" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 6, 11, 40, 45, 563, DateTimeKind.Local).AddTicks(6981), 3, 2, "Knjiga je okeej!" },
                    { 2, new DateTime(2022, 1, 6, 11, 40, 45, 563, DateTimeKind.Local).AddTicks(8436), 2, 2, "Knjiga je dosadna!" },
                    { 3, new DateTime(2022, 1, 6, 11, 40, 45, 563, DateTimeKind.Local).AddTicks(8458), 1, 2, "Preporucujem knjiguu!" }
                });

            migrationBuilder.InsertData(
                table: "KorisnikKnjigaOcjena",
                columns: new[] { "KorisnikKnjigaOcjena_ID", "DatumOcjene", "Knjiga_ID", "Korisnik_ID", "Ocjena" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 6, 11, 40, 45, 564, DateTimeKind.Local).AddTicks(5580), 3, 2, 4.5 },
                    { 2, new DateTime(2022, 1, 6, 11, 40, 45, 564, DateTimeKind.Local).AddTicks(6278), 2, 2, 4.9000000000000004 },
                    { 3, new DateTime(2022, 1, 6, 11, 40, 45, 564, DateTimeKind.Local).AddTicks(6299), 1, 2, 4.0999999999999996 }
                });

            migrationBuilder.InsertData(
                table: "KupovinaKnjige",
                columns: new[] { "KupovinaKnjige_ID", "DatumKupovine", "Knjiga_ID", "Korisnik_ID", "Odobreno", "Placanje_ID" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 6, 11, 40, 45, 565, DateTimeKind.Local).AddTicks(3488), 1, 2, true, 1 },
                    { 2, new DateTime(2022, 1, 6, 11, 40, 45, 565, DateTimeKind.Local).AddTicks(5601), 3, 2, false, 2 },
                    { 3, new DateTime(2022, 1, 6, 11, 40, 45, 565, DateTimeKind.Local).AddTicks(5624), 2, 2, true, 2 }
                });

            migrationBuilder.InsertData(
                table: "PrijedlogKnjige",
                columns: new[] { "PrijedlogKnjige_ID", "DatumPrijedloga", "Korisnik_ID", "NazivPrijedlogaKnjige", "Odgovoren", "Opis", "Pregledan" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 6, 11, 40, 45, 562, DateTimeKind.Local).AddTicks(7691), 2, "Zeleno busenje", true, "Ovaj zahtjev je odobren!", true },
                    { 2, new DateTime(2022, 1, 6, 11, 40, 45, 563, DateTimeKind.Local).AddTicks(306), 2, "Orlovi rano lete", false, "Cekanje na zahtjev!", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Grad_Drzava_ID",
                table: "Grad",
                column: "Drzava_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaPisac_Knjiga_ID",
                table: "KnjigaPisac",
                column: "Knjiga_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaPisac_Pisac_ID",
                table: "KnjigaPisac",
                column: "Pisac_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaZanr_Knjiga_ID",
                table: "KnjigaZanr",
                column: "Knjiga_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KnjigaZanr_Zanr_ID",
                table: "KnjigaZanr",
                column: "Zanr_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Grad_ID",
                table: "Korisnik",
                column: "Grad_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Spol_ID",
                table: "Korisnik",
                column: "Spol_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnik_Uloga_ID",
                table: "Korisnik",
                column: "Uloga_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikKnjigaKomentar_Knjiga_ID",
                table: "KorisnikKnjigaKomentar",
                column: "Knjiga_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikKnjigaKomentar_Korisnik_ID",
                table: "KorisnikKnjigaKomentar",
                column: "Korisnik_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikKnjigaOcjena_Knjiga_ID",
                table: "KorisnikKnjigaOcjena",
                column: "Knjiga_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikKnjigaOcjena_Korisnik_ID",
                table: "KorisnikKnjigaOcjena",
                column: "Korisnik_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaKnjige_Knjiga_ID",
                table: "KupovinaKnjige",
                column: "Knjiga_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaKnjige_Korisnik_ID",
                table: "KupovinaKnjige",
                column: "Korisnik_ID");

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaKnjige_Placanje_ID",
                table: "KupovinaKnjige",
                column: "Placanje_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Pisac_Grad_ID",
                table: "Pisac",
                column: "Grad_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Placanje_NacinPlacanja_ID",
                table: "Placanje",
                column: "NacinPlacanja_ID");

            migrationBuilder.CreateIndex(
                name: "IX_PrijedlogKnjige_Korisnik_ID",
                table: "PrijedlogKnjige",
                column: "Korisnik_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnjigaPisac");

            migrationBuilder.DropTable(
                name: "KnjigaZanr");

            migrationBuilder.DropTable(
                name: "KorisnikKnjigaKomentar");

            migrationBuilder.DropTable(
                name: "KorisnikKnjigaOcjena");

            migrationBuilder.DropTable(
                name: "KupovinaKnjige");

            migrationBuilder.DropTable(
                name: "PrijedlogKnjige");

            migrationBuilder.DropTable(
                name: "Pisac");

            migrationBuilder.DropTable(
                name: "Zanr");

            migrationBuilder.DropTable(
                name: "Knjiga");

            migrationBuilder.DropTable(
                name: "Placanje");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "NacinPlacanja");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Spol");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
