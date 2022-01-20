using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Migrations
{
    public partial class KorisnikKnjigaKomentar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Komentar_ID",
                table: "KorisnikKnjigaKomentar",
                newName: "KorisnikKnjigaKomentar_ID");

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 820, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 820, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 820, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 819, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 819, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 820, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 820, DateTimeKind.Local).AddTicks(9216));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 820, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 821, DateTimeKind.Local).AddTicks(1431));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 821, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 821, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 821, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 821, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 821, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 817, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 818, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 818, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 818, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 2,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 821, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 4,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 821, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 820, DateTimeKind.Local).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 20, 12, 32, 54, 820, DateTimeKind.Local).AddTicks(6615));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KorisnikKnjigaKomentar_ID",
                table: "KorisnikKnjigaKomentar",
                newName: "Komentar_ID");

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 560, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 560, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 560, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 559, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 559, DateTimeKind.Local).AddTicks(7587));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "Komentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 563, DateTimeKind.Local).AddTicks(6981));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "Komentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 563, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "Komentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 563, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 564, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 564, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 564, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 565, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 565, DateTimeKind.Local).AddTicks(5601));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 565, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 552, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 557, DateTimeKind.Local).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 557, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 557, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 2,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 566, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 4,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 567, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 562, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 6, 11, 40, 45, 563, DateTimeKind.Local).AddTicks(306));
        }
    }
}
