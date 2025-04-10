﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eLibrary.Migrations
{
    public partial class RemoveNacinPlacanja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Placanje");

            migrationBuilder.DropTable(
                name: "NacinPlacanja");

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                columns: new[] { "DatumIzdavanja"},
                values: new object[] { new DateTime(2022, 2, 15, 15, 25, 39, 276, DateTimeKind.Local).AddTicks(2667)});

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                columns: new[] { "DatumIzdavanja"},
                values: new object[] { new DateTime(2022, 2, 15, 15, 25, 39, 276, DateTimeKind.Local).AddTicks(3203)});

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                columns: new[] { "DatumIzdavanja" },
                values: new object[] { new DateTime(2022, 2, 15, 15, 25, 39, 276, DateTimeKind.Local).AddTicks(3212)});

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                columns: new[] { "DatumRodjenja" },
                values: new object[] { new DateTime(2022, 2, 15, 15, 25, 39, 275, DateTimeKind.Local).AddTicks(6815) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                columns: new[] { "DatumRodjenja"},
                values: new object[] { new DateTime(2022, 2, 15, 15, 25, 39, 275, DateTimeKind.Local).AddTicks(8373) });

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 3,
                columns: new[] { "DatumRodjenja" },
                values: new object[] { new DateTime(2022, 2, 15, 15, 25, 39, 275, DateTimeKind.Local).AddTicks(8383)});

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 276, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 276, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 276, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 277, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 277, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 277, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 277, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 277, DateTimeKind.Local).AddTicks(4378));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 277, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 273, DateTimeKind.Local).AddTicks(4428));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 274, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 274, DateTimeKind.Local).AddTicks(9829));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 274, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 276, DateTimeKind.Local).AddTicks(5281));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 15, 15, 25, 39, 276, DateTimeKind.Local).AddTicks(5967));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 1,
                column:"DatumIzdavanja",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 2, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 2,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 2, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "Knjiga",
                keyColumn: "Knjiga_ID",
                keyValue: 3,
                column: "DatumIzdavanja",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 2, DateTimeKind.Local).AddTicks(8658));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value:  new DateTime(2022, 2, 4, 12, 41, 57, 1, DateTimeKind.Local).AddTicks(2309));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 1, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Korisnik",
                keyColumn: "Korisnik_ID",
                keyValue: 3,
                column:"DatumRodjenja" ,
                value:new DateTime(2022, 2, 4, 12, 41, 57, 1, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 1,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(3810));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 2,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaKomentar",
                keyColumn: "KorisnikKnjigaKomentar_ID",
                keyValue: 3,
                column: "DatumKomentara",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 1,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 2,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "KorisnikKnjigaOcjena",
                keyColumn: "KorisnikKnjigaOcjena_ID",
                keyValue: 3,
                column: "DatumOcjene",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "KupovinaKnjige",
                keyColumn: "KupovinaKnjige_ID",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(9143));

            migrationBuilder.InsertData(
                table: "NacinPlacanja",
                columns: new[] { "NacinPlacanja_ID", "Naziv" },
                values: new object[,]
                {
                    { 1, "Placanje bankovnom karticom." },
                    { 2, "PayPal" }
                });

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 1,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 4, 12, 41, 56, 999, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 2,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 0, DateTimeKind.Local).AddTicks(5476));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 3,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 0, DateTimeKind.Local).AddTicks(5498));

            migrationBuilder.UpdateData(
                table: "Pisac",
                keyColumn: "Pisac_ID",
                keyValue: 4,
                column: "DatumRodjenja",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 0, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 1,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "PrijedlogKnjige",
                keyColumn: "PrijedlogKnjige_ID",
                keyValue: 2,
                column: "DatumPrijedloga",
                value: new DateTime(2022, 2, 4, 12, 41, 57, 3, DateTimeKind.Local).AddTicks(1466));

            
        }
    }
}
