using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Migrations
{
    public partial class UpdatedKorisnici : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DatumRodjenja", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 2, 3, 16, 5, 39, 218, DateTimeKind.Local).AddTicks(7420), "YAWTUq0ie8c0tBtxDe8Cv5BcEkU=", "2347UVaXDf0JXS/13WCCdg==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 2, 3, 16, 5, 39, 219, DateTimeKind.Local).AddTicks(519), "S27pePLiy7wnHja89giP/L4RQ6s=", "S5felu6ihLLEtjNKQZMaSA==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 2, 3, 16, 5, 39, 219, DateTimeKind.Local).AddTicks(1305), "Y/rtFbnRSgQ53PX3+w9lEoqiJ2s=", "WqHzH1hIBtmsewpNDEpeGg==" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 910, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 910, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 910, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 2, 3, 14, 26, 4, 909, DateTimeKind.Local).AddTicks(8391), "VBuAbDHw4VpNmit99/1kQD6iHdc=", "vlB5aDodOZ9CzpJgJb2YTw==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 2, 3, 14, 26, 4, 910, DateTimeKind.Local).AddTicks(1665), "cfYKzFiOX9/2wn+uO0D+eQpVC6Q=", "xgZcl8UKsYKT6W/UVNAQ5A==" });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 2, 3, 14, 26, 4, 910, DateTimeKind.Local).AddTicks(2189), "Uc6V3AKyDPojPD7/DUOOgxj/J4g=", "4WBY01YbHGSswAHe68uTBg==" });

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 911, DateTimeKind.Local).AddTicks(5294));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 911, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 911, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 911, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 911, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 911, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 912, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 912, DateTimeKind.Local).AddTicks(939));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 912, DateTimeKind.Local).AddTicks(947));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 907, DateTimeKind.Local).AddTicks(5550));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 909, DateTimeKind.Local).AddTicks(1141));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 909, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 909, DateTimeKind.Local).AddTicks(1169));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 2,
                column: "DatumPlacanja",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 912, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "Placanje",
                keyColumn: "Placanje_ID",
                keyValue: 4,
                column: "DatumPlacanja",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 912, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 911, DateTimeKind.Local).AddTicks(2312));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 3, 14, 26, 4, 911, DateTimeKind.Local).AddTicks(2931));
        }
    }
}
