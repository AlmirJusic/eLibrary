using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Migrations
{
    public partial class UpdateKorisnici : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 296, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 296, DateTimeKind.Local).AddTicks(9598));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 296, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 1, 23, 22, 38, 13, 296, DateTimeKind.Local).AddTicks(4344), "VBuAbDHw4VpNmit99/1kQD6iHdc=", "vlB5aDodOZ9CzpJgJb2YTw==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 296, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 297, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 297, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 297, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 298, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 298, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 298, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 298, DateTimeKind.Local).AddTicks(4092));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 298, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 298, DateTimeKind.Local).AddTicks(4999));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 294, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 295, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 295, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 295, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 2,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 299, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 4,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 299, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 297, DateTimeKind.Local).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 23, 22, 38, 13, 297, DateTimeKind.Local).AddTicks(6407));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 769, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 770, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 770, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 1, 23, 21, 31, 47, 769, DateTimeKind.Local).AddTicks(4847), "/", "/" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 769, DateTimeKind.Local).AddTicks(6412));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 770, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 770, DateTimeKind.Local).AddTicks(9581));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 770, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 771, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 771, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 771, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 771, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 771, DateTimeKind.Local).AddTicks(4913));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 771, DateTimeKind.Local).AddTicks(4922));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 767, DateTimeKind.Local).AddTicks(2143));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 768, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 768, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 768, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 2,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 771, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 4,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 771, DateTimeKind.Local).AddTicks(9945));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 770, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 23, 21, 31, 47, 770, DateTimeKind.Local).AddTicks(6878));
        }
    }
}
