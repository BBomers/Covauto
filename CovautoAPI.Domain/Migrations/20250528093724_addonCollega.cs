using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CovautoAPI.Domain.Migrations
{
    /// <inheritdoc />
    public partial class addonCollega : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "collega",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Naam = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collega", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "leenAutos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Kenteken = table.Column<string>(type: "TEXT", nullable: false),
                    KilometerStand = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leenAutos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reserveringData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReserveringID = table.Column<int>(type: "INTEGER", nullable: false),
                    StartStraat = table.Column<string>(type: "TEXT", nullable: false),
                    StartPostcode = table.Column<string>(type: "TEXT", nullable: false),
                    StartStad = table.Column<string>(type: "TEXT", nullable: false),
                    ToStraat = table.Column<string>(type: "TEXT", nullable: false),
                    ToPostcode = table.Column<string>(type: "TEXT", nullable: false),
                    ToStad = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserveringData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "reserveringen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LeenAutoID = table.Column<int>(type: "INTEGER", nullable: false),
                    CollegaID = table.Column<int>(type: "INTEGER", nullable: false),
                    ReserveerDatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BoekDatumVanaf = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BoekDatumTot = table.Column<DateTime>(type: "TEXT", nullable: false),
                    KilometerStand = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reserveringen", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "collega",
                columns: new[] { "Id", "Naam" },
                values: new object[,]
                {
                    { 1, "Sophie Janssen" },
                    { 2, "Tom Vermeer" },
                    { 3, "Lotte de Vries" }
                });

            migrationBuilder.InsertData(
                table: "leenAutos",
                columns: new[] { "Id", "Kenteken", "KilometerStand" },
                values: new object[,]
                {
                    { 1, "AA-123-AA", 10000 },
                    { 2, "BB-234-BB", 20000 },
                    { 3, "CC-345-CC", 30000 }
                });

            migrationBuilder.InsertData(
                table: "reserveringData",
                columns: new[] { "Id", "ReserveringID", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[,]
                {
                    { 1, 1, "1234AB", "StadA", "Startstraat 1-1", "5678CD", "StadB", "Tostraat 1-1" },
                    { 2, 1, "2233EF", "StadC", "Startstraat 1-2", "8899GH", "StadD", "Tostraat 1-2" },
                    { 3, 2, "1234AB", "StadA", "Startstraat 2-1", "5678CD", "StadB", "Tostraat 2-1" },
                    { 4, 2, "2233EF", "StadC", "Startstraat 2-2", "8899GH", "StadD", "Tostraat 2-2" },
                    { 5, 3, "1234AB", "StadA", "Startstraat 3-1", "5678CD", "StadB", "Tostraat 3-1" },
                    { 6, 3, "2233EF", "StadC", "Startstraat 3-2", "8899GH", "StadD", "Tostraat 3-2" },
                    { 7, 4, "1234AB", "StadA", "Startstraat 4-1", "5678CD", "StadB", "Tostraat 4-1" },
                    { 8, 4, "2233EF", "StadC", "Startstraat 4-2", "8899GH", "StadD", "Tostraat 4-2" },
                    { 9, 5, "1234AB", "StadA", "Startstraat 5-1", "5678CD", "StadB", "Tostraat 5-1" },
                    { 10, 5, "2233EF", "StadC", "Startstraat 5-2", "8899GH", "StadD", "Tostraat 5-2" },
                    { 11, 6, "1234AB", "StadA", "Startstraat 6-1", "5678CD", "StadB", "Tostraat 6-1" },
                    { 12, 6, "2233EF", "StadC", "Startstraat 6-2", "8899GH", "StadD", "Tostraat 6-2" },
                    { 13, 7, "1234AB", "StadA", "Startstraat 7-1", "5678CD", "StadB", "Tostraat 7-1" },
                    { 14, 7, "2233EF", "StadC", "Startstraat 7-2", "8899GH", "StadD", "Tostraat 7-2" },
                    { 15, 8, "1234AB", "StadA", "Startstraat 8-1", "5678CD", "StadB", "Tostraat 8-1" },
                    { 16, 8, "2233EF", "StadC", "Startstraat 8-2", "8899GH", "StadD", "Tostraat 8-2" },
                    { 17, 9, "1234AB", "StadA", "Startstraat 9-1", "5678CD", "StadB", "Tostraat 9-1" },
                    { 18, 9, "2233EF", "StadC", "Startstraat 9-2", "8899GH", "StadD", "Tostraat 9-2" },
                    { 19, 10, "1234AB", "StadA", "Startstraat 10-1", "5678CD", "StadB", "Tostraat 10-1" },
                    { 20, 10, "2233EF", "StadC", "Startstraat 10-2", "8899GH", "StadD", "Tostraat 10-2" },
                    { 21, 11, "1234AB", "StadA", "Startstraat 11-1", "5678CD", "StadB", "Tostraat 11-1" },
                    { 22, 11, "2233EF", "StadC", "Startstraat 11-2", "8899GH", "StadD", "Tostraat 11-2" },
                    { 23, 12, "1234AB", "StadA", "Startstraat 12-1", "5678CD", "StadB", "Tostraat 12-1" },
                    { 24, 12, "2233EF", "StadC", "Startstraat 12-2", "8899GH", "StadD", "Tostraat 12-2" },
                    { 25, 13, "1234AB", "StadA", "Startstraat 13-1", "5678CD", "StadB", "Tostraat 13-1" },
                    { 26, 13, "2233EF", "StadC", "Startstraat 13-2", "8899GH", "StadD", "Tostraat 13-2" },
                    { 27, 14, "1234AB", "StadA", "Startstraat 14-1", "5678CD", "StadB", "Tostraat 14-1" },
                    { 28, 14, "2233EF", "StadC", "Startstraat 14-2", "8899GH", "StadD", "Tostraat 14-2" },
                    { 29, 15, "1234AB", "StadA", "Startstraat 15-1", "5678CD", "StadB", "Tostraat 15-1" },
                    { 30, 15, "2233EF", "StadC", "Startstraat 15-2", "8899GH", "StadD", "Tostraat 15-2" },
                    { 31, 16, "1234AB", "StadA", "Startstraat 16-1", "5678CD", "StadB", "Tostraat 16-1" },
                    { 32, 16, "2233EF", "StadC", "Startstraat 16-2", "8899GH", "StadD", "Tostraat 16-2" },
                    { 33, 17, "1234AB", "StadA", "Startstraat 17-1", "5678CD", "StadB", "Tostraat 17-1" },
                    { 34, 17, "2233EF", "StadC", "Startstraat 17-2", "8899GH", "StadD", "Tostraat 17-2" },
                    { 35, 18, "1234AB", "StadA", "Startstraat 18-1", "5678CD", "StadB", "Tostraat 18-1" },
                    { 36, 18, "2233EF", "StadC", "Startstraat 18-2", "8899GH", "StadD", "Tostraat 18-2" },
                    { 37, 19, "1234AB", "StadA", "Startstraat 19-1", "5678CD", "StadB", "Tostraat 19-1" },
                    { 38, 19, "2233EF", "StadC", "Startstraat 19-2", "8899GH", "StadD", "Tostraat 19-2" },
                    { 39, 20, "1234AB", "StadA", "Startstraat 20-1", "5678CD", "StadB", "Tostraat 20-1" },
                    { 40, 20, "2233EF", "StadC", "Startstraat 20-2", "8899GH", "StadD", "Tostraat 20-2" },
                    { 41, 21, "1234AB", "StadA", "Startstraat 21-1", "5678CD", "StadB", "Tostraat 21-1" },
                    { 42, 21, "2233EF", "StadC", "Startstraat 21-2", "8899GH", "StadD", "Tostraat 21-2" },
                    { 43, 22, "1234AB", "StadA", "Startstraat 22-1", "5678CD", "StadB", "Tostraat 22-1" },
                    { 44, 22, "2233EF", "StadC", "Startstraat 22-2", "8899GH", "StadD", "Tostraat 22-2" },
                    { 45, 23, "1234AB", "StadA", "Startstraat 23-1", "5678CD", "StadB", "Tostraat 23-1" },
                    { 46, 23, "2233EF", "StadC", "Startstraat 23-2", "8899GH", "StadD", "Tostraat 23-2" },
                    { 47, 24, "1234AB", "StadA", "Startstraat 24-1", "5678CD", "StadB", "Tostraat 24-1" },
                    { 48, 24, "2233EF", "StadC", "Startstraat 24-2", "8899GH", "StadD", "Tostraat 24-2" }
                });

            migrationBuilder.InsertData(
                table: "reserveringen",
                columns: new[] { "Id", "BoekDatumTot", "BoekDatumVanaf", "CollegaID", "KilometerStand", "LeenAutoID", "ReserveerDatum" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 1, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 1, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 1, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 1, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 1, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 1, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 1, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 1, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2, new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2, new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2, new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2, new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 2, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 3, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 3, new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 3, new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 3, new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 3, new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 3, new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 3, new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, 3, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "collega");

            migrationBuilder.DropTable(
                name: "leenAutos");

            migrationBuilder.DropTable(
                name: "reserveringData");

            migrationBuilder.DropTable(
                name: "reserveringen");
        }
    }
}
