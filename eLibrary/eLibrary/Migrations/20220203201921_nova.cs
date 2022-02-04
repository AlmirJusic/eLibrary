using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Migrations
{
    public partial class nova : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 279, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 280, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 280, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 278, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 279, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 279, DateTimeKind.Local).AddTicks(3941));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 280, DateTimeKind.Local).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 280, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 280, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 281, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 281, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 281, DateTimeKind.Local).AddTicks(276));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 281, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 281, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 281, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 276, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 278, DateTimeKind.Local).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 278, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 278, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 2,
                column: "DatumPlacanja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 281, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 4,
                column: "DatumPlacanja",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 281, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 280, DateTimeKind.Local).AddTicks(4510));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 3, 21, 19, 21, 280, DateTimeKind.Local).AddTicks(5126));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 219, DateTimeKind.Local).AddTicks(6665));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 219, DateTimeKind.Local).AddTicks(7996));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 219, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 218, DateTimeKind.Local).AddTicks(7420));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 219, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 219, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 220, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 220, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 220, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 220, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 220, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 220, DateTimeKind.Local).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 220, DateTimeKind.Local).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 221, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 221, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 216, DateTimeKind.Local).AddTicks(5211));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 218, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 218, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 218, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 2,
                column: "DatumPlacanja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 221, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 4,
                column: "DatumPlacanja",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 221, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 220, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 3, 16, 5, 39, 220, DateTimeKind.Local).AddTicks(2189));
        }
    }
}
