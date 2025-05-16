using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CovautoAPI.Domain.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "ReserveringData",
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
                    ToStad = table.Column<string>(type: "TEXT", nullable: false),
                    KilometerStand = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReserveringData", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reserveringen",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LeenAutoID = table.Column<int>(type: "INTEGER", nullable: false),
                    ReserveerDatum = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BoekDatumVanaf = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BoekDatumTot = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserveringen", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ReserveringData",
                columns: new[] { "Id", "KilometerStand", "ReserveringID", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[,]
                {
                    { 1, 15000, 1, "1234AA", "Startstad", "Startstraat 0", "5678BB", "Bestemmingstad", "Bestemmingstraat 0" },
                    { 2, 15020, 1, "1234AB", "Startstad B", "Startstraat 0B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 0B" },
                    { 3, 15100, 2, "1234AA", "Startstad", "Startstraat 1", "5678BB", "Bestemmingstad", "Bestemmingstraat 1" },
                    { 4, 15120, 2, "1234AB", "Startstad B", "Startstraat 1B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 1B" },
                    { 5, 15200, 3, "1234AA", "Startstad", "Startstraat 2", "5678BB", "Bestemmingstad", "Bestemmingstraat 2" },
                    { 6, 15220, 3, "1234AB", "Startstad B", "Startstraat 2B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 2B" },
                    { 7, 15300, 4, "1234AA", "Startstad", "Startstraat 3", "5678BB", "Bestemmingstad", "Bestemmingstraat 3" },
                    { 8, 15320, 4, "1234AB", "Startstad B", "Startstraat 3B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 3B" },
                    { 9, 15400, 5, "1234AA", "Startstad", "Startstraat 4", "5678BB", "Bestemmingstad", "Bestemmingstraat 4" },
                    { 10, 15420, 5, "1234AB", "Startstad B", "Startstraat 4B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 4B" },
                    { 11, 15500, 6, "1234AA", "Startstad", "Startstraat 5", "5678BB", "Bestemmingstad", "Bestemmingstraat 5" },
                    { 12, 15520, 6, "1234AB", "Startstad B", "Startstraat 5B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 5B" },
                    { 13, 15600, 7, "1234AA", "Startstad", "Startstraat 6", "5678BB", "Bestemmingstad", "Bestemmingstraat 6" },
                    { 14, 15620, 7, "1234AB", "Startstad B", "Startstraat 6B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 6B" },
                    { 15, 15700, 8, "1234AA", "Startstad", "Startstraat 7", "5678BB", "Bestemmingstad", "Bestemmingstraat 7" },
                    { 16, 15720, 8, "1234AB", "Startstad B", "Startstraat 7B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 7B" },
                    { 17, 15000, 9, "1234AA", "Startstad", "Startstraat 0", "5678BB", "Bestemmingstad", "Bestemmingstraat 0" },
                    { 18, 15020, 9, "1234AB", "Startstad B", "Startstraat 0B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 0B" },
                    { 19, 15100, 10, "1234AA", "Startstad", "Startstraat 1", "5678BB", "Bestemmingstad", "Bestemmingstraat 1" },
                    { 20, 15120, 10, "1234AB", "Startstad B", "Startstraat 1B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 1B" },
                    { 21, 15200, 11, "1234AA", "Startstad", "Startstraat 2", "5678BB", "Bestemmingstad", "Bestemmingstraat 2" },
                    { 22, 15220, 11, "1234AB", "Startstad B", "Startstraat 2B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 2B" },
                    { 23, 15300, 12, "1234AA", "Startstad", "Startstraat 3", "5678BB", "Bestemmingstad", "Bestemmingstraat 3" },
                    { 24, 15320, 12, "1234AB", "Startstad B", "Startstraat 3B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 3B" },
                    { 25, 15400, 13, "1234AA", "Startstad", "Startstraat 4", "5678BB", "Bestemmingstad", "Bestemmingstraat 4" },
                    { 26, 15420, 13, "1234AB", "Startstad B", "Startstraat 4B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 4B" },
                    { 27, 15500, 14, "1234AA", "Startstad", "Startstraat 5", "5678BB", "Bestemmingstad", "Bestemmingstraat 5" },
                    { 28, 15520, 14, "1234AB", "Startstad B", "Startstraat 5B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 5B" },
                    { 29, 15600, 15, "1234AA", "Startstad", "Startstraat 6", "5678BB", "Bestemmingstad", "Bestemmingstraat 6" },
                    { 30, 15620, 15, "1234AB", "Startstad B", "Startstraat 6B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 6B" },
                    { 31, 15700, 16, "1234AA", "Startstad", "Startstraat 7", "5678BB", "Bestemmingstad", "Bestemmingstraat 7" },
                    { 32, 15720, 16, "1234AB", "Startstad B", "Startstraat 7B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 7B" },
                    { 33, 15000, 17, "1234AA", "Startstad", "Startstraat 0", "5678BB", "Bestemmingstad", "Bestemmingstraat 0" },
                    { 34, 15020, 17, "1234AB", "Startstad B", "Startstraat 0B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 0B" },
                    { 35, 15100, 18, "1234AA", "Startstad", "Startstraat 1", "5678BB", "Bestemmingstad", "Bestemmingstraat 1" },
                    { 36, 15120, 18, "1234AB", "Startstad B", "Startstraat 1B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 1B" },
                    { 37, 15200, 19, "1234AA", "Startstad", "Startstraat 2", "5678BB", "Bestemmingstad", "Bestemmingstraat 2" },
                    { 38, 15220, 19, "1234AB", "Startstad B", "Startstraat 2B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 2B" },
                    { 39, 15300, 20, "1234AA", "Startstad", "Startstraat 3", "5678BB", "Bestemmingstad", "Bestemmingstraat 3" },
                    { 40, 15320, 20, "1234AB", "Startstad B", "Startstraat 3B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 3B" },
                    { 41, 15400, 21, "1234AA", "Startstad", "Startstraat 4", "5678BB", "Bestemmingstad", "Bestemmingstraat 4" },
                    { 42, 15420, 21, "1234AB", "Startstad B", "Startstraat 4B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 4B" },
                    { 43, 15500, 22, "1234AA", "Startstad", "Startstraat 5", "5678BB", "Bestemmingstad", "Bestemmingstraat 5" },
                    { 44, 15520, 22, "1234AB", "Startstad B", "Startstraat 5B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 5B" },
                    { 45, 15600, 23, "1234AA", "Startstad", "Startstraat 6", "5678BB", "Bestemmingstad", "Bestemmingstraat 6" },
                    { 46, 15620, 23, "1234AB", "Startstad B", "Startstraat 6B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 6B" },
                    { 47, 15700, 24, "1234AA", "Startstad", "Startstraat 7", "5678BB", "Bestemmingstad", "Bestemmingstraat 7" },
                    { 48, 15720, 24, "1234AB", "Startstad B", "Startstraat 7B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 7B" }
                });

            migrationBuilder.InsertData(
                table: "Reserveringen",
                columns: new[] { "Id", "BoekDatumTot", "BoekDatumVanaf", "LeenAutoID", "ReserveerDatum" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 18, 11, 5, 43, 401, DateTimeKind.Local).AddTicks(8136), new DateTime(2025, 5, 16, 11, 5, 43, 401, DateTimeKind.Local).AddTicks(7889), 1, new DateTime(2025, 5, 6, 11, 5, 43, 399, DateTimeKind.Local).AddTicks(456) },
                    { 2, new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2502), new DateTime(2025, 5, 17, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2500), 1, new DateTime(2025, 5, 7, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2487) },
                    { 3, new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2598), new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2597), 1, new DateTime(2025, 5, 8, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2595) },
                    { 4, new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2642), new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2641), 1, new DateTime(2025, 5, 9, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2640) },
                    { 5, new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2664), new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2663), 1, new DateTime(2025, 5, 10, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2661) },
                    { 6, new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2688), new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2687), 1, new DateTime(2025, 5, 11, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2685) },
                    { 7, new DateTime(2025, 5, 24, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2715), new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2714), 1, new DateTime(2025, 5, 12, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2712) },
                    { 8, new DateTime(2025, 5, 25, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2736), new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2735), 1, new DateTime(2025, 5, 13, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2733) },
                    { 9, new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2758), new DateTime(2025, 5, 16, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2756), 2, new DateTime(2025, 5, 6, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2755) },
                    { 10, new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2781), new DateTime(2025, 5, 17, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2780), 2, new DateTime(2025, 5, 7, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2779) },
                    { 11, new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2803), new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2802), 2, new DateTime(2025, 5, 8, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2800) },
                    { 12, new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2903), new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2902), 2, new DateTime(2025, 5, 9, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2901) },
                    { 13, new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2927), new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2925), 2, new DateTime(2025, 5, 10, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2924) },
                    { 14, new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2948), new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2947), 2, new DateTime(2025, 5, 11, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2945) },
                    { 15, new DateTime(2025, 5, 24, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2974), new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2973), 2, new DateTime(2025, 5, 12, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2972) },
                    { 16, new DateTime(2025, 5, 25, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2998), 2, new DateTime(2025, 5, 13, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2996) },
                    { 17, new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3027), new DateTime(2025, 5, 16, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3026), 3, new DateTime(2025, 5, 6, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3024) },
                    { 18, new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3056), new DateTime(2025, 5, 17, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3055), 3, new DateTime(2025, 5, 7, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3054) },
                    { 19, new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3082), new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3081), 3, new DateTime(2025, 5, 8, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3080) },
                    { 20, new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3143), new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3142), 3, new DateTime(2025, 5, 9, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3140) },
                    { 21, new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3168), new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3167), 3, new DateTime(2025, 5, 10, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3166) },
                    { 22, new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3194), new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3193), 3, new DateTime(2025, 5, 11, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3192) },
                    { 23, new DateTime(2025, 5, 24, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3219), new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3218), 3, new DateTime(2025, 5, 12, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3216) },
                    { 24, new DateTime(2025, 5, 25, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3242), new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3241), 3, new DateTime(2025, 5, 13, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3240) }
                });

            migrationBuilder.InsertData(
                table: "leenAutos",
                columns: new[] { "Id", "Kenteken", "KilometerStand" },
                values: new object[,]
                {
                    { 1, "AB-123-CD", 15000 },
                    { 2, "EF-456-GH", 20000 },
                    { 3, "IJ-789-KL", 25000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "leenAutos");

            migrationBuilder.DropTable(
                name: "ReserveringData");

            migrationBuilder.DropTable(
                name: "Reserveringen");
        }
    }
}
