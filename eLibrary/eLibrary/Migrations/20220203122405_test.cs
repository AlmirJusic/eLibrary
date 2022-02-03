using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_KupovinaKnjige_Placanje_Placanje_ID",
                table: "KupovinaKnjige");

            migrationBuilder.DropIndex(
                name: "IX_KupovinaKnjige_Placanje_ID",
                table: "KupovinaKnjige");

            migrationBuilder.DropColumn(
                name: "Placanje_ID",
                table: "KupovinaKnjige");

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 825, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 825, DateTimeKind.Local).AddTicks(1448));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 825, DateTimeKind.Local).AddTicks(1459));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 824, DateTimeKind.Local).AddTicks(1515));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 824, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 824, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 825, DateTimeKind.Local).AddTicks(7178));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 825, DateTimeKind.Local).AddTicks(7548));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 825, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 825, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 826, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 826, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 826, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 826, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 826, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 821, DateTimeKind.Local).AddTicks(4877));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 823, DateTimeKind.Local).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 823, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 823, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 2,
                column: "DatumPlacanja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 826, DateTimeKind.Local).AddTicks(8428));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 4,
                column: "DatumPlacanja",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 826, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 825, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 3, 13, 24, 4, 825, DateTimeKind.Local).AddTicks(4767));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Placanje_ID",
                table: "KupovinaKnjige",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 324, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 324, DateTimeKind.Local).AddTicks(4920));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 324, DateTimeKind.Local).AddTicks(4929));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 322, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 323, DateTimeKind.Local).AddTicks(7080));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 323, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 325, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 325, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 325, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 325, DateTimeKind.Local).AddTicks(3088));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 325, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 325, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                columns: new[] { "DatumKupovine", "Placanje_ID" },
                values: new object[] { new DateTime(2022, 1, 25, 12, 17, 43, 325, DateTimeKind.Local).AddTicks(5661), 1 });

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                columns: new[] { "DatumKupovine", "Placanje_ID" },
                values: new object[] { new DateTime(2022, 1, 25, 12, 17, 43, 325, DateTimeKind.Local).AddTicks(6175), 2 });

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                columns: new[] { "DatumKupovine", "Placanje_ID" },
                values: new object[] { new DateTime(2022, 1, 25, 12, 17, 43, 325, DateTimeKind.Local).AddTicks(6184), 2 });

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 320, DateTimeKind.Local).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 322, DateTimeKind.Local).AddTicks(1174));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 322, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 322, DateTimeKind.Local).AddTicks(1202));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 2,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 326, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 4,
                column: "DatumPlacanja",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 326, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 324, DateTimeKind.Local).AddTicks(7098));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 1, 25, 12, 17, 43, 324, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.CreateIndex(
                name: "IX_KupovinaKnjige_Placanje_ID",
                table: "KupovinaKnjige",
                column: "Placanje_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_KupovinaKnjige_Placanje_Placanje_ID",
                table: "KupovinaKnjige",
                column: "Placanje_ID",
                principalTable: "Placanje",
                principalColumn: "Placanje_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
