using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CovautoAPI.Domain.Migrations
{
    /// <inheritdoc />
    public partial class initsecond : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LeenAuto",
                columns: new[] { "Id", "Kenteken", "KilometerStand" },
                values: new object[,]
                {
                    { 1, "XX-123-X", 50000 },
                    { 2, "YY-456-Y", 35000 }
                });

            migrationBuilder.InsertData(
                table: "ReserveringData",
                columns: new[] { "Id", "KilometerStand", "ReserveringID", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 1, 50200, 1, "1234AB", "Utrecht", "Startstraat 1", "5678CD", "Amsterdam", "Eindstraat 5" });

            migrationBuilder.InsertData(
                table: "Reservingen",
                columns: new[] { "Id", "BoekDatumTot", "BoekDatumVanaf", "LeenAutoID", "ReserveerDatum" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 5, 1, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2024, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 5, 3, 15, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LeenAuto",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LeenAuto",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservingen",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservingen",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
