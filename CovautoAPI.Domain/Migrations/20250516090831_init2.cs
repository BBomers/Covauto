using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CovautoAPI.Domain.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10001, "1234AB", "StadA", "Startstraat 1-1", "5678CD", "StadB", "Tostraat 1-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10011, "2233EF", "StadC", "Startstraat 1-2", "8899GH", "StadD", "Tostraat 1-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10002, "1234AB", "StadA", "Startstraat 2-1", "5678CD", "StadB", "Tostraat 2-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10012, "2233EF", "StadC", "Startstraat 2-2", "8899GH", "StadD", "Tostraat 2-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10003, "1234AB", "StadA", "Startstraat 3-1", "5678CD", "StadB", "Tostraat 3-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10013, "2233EF", "StadC", "Startstraat 3-2", "8899GH", "StadD", "Tostraat 3-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10004, "1234AB", "StadA", "Startstraat 4-1", "5678CD", "StadB", "Tostraat 4-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10014, "2233EF", "StadC", "Startstraat 4-2", "8899GH", "StadD", "Tostraat 4-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10005, "1234AB", "StadA", "Startstraat 5-1", "5678CD", "StadB", "Tostraat 5-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10015, "2233EF", "StadC", "Startstraat 5-2", "8899GH", "StadD", "Tostraat 5-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10006, "1234AB", "StadA", "Startstraat 6-1", "5678CD", "StadB", "Tostraat 6-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10016, "2233EF", "StadC", "Startstraat 6-2", "8899GH", "StadD", "Tostraat 6-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10007, "1234AB", "StadA", "Startstraat 7-1", "5678CD", "StadB", "Tostraat 7-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10017, "2233EF", "StadC", "Startstraat 7-2", "8899GH", "StadD", "Tostraat 7-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10008, "1234AB", "StadA", "Startstraat 8-1", "5678CD", "StadB", "Tostraat 8-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10018, "2233EF", "StadC", "Startstraat 8-2", "8899GH", "StadD", "Tostraat 8-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10009, "1234AB", "StadA", "Startstraat 9-1", "5678CD", "StadB", "Tostraat 9-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10019, "2233EF", "StadC", "Startstraat 9-2", "8899GH", "StadD", "Tostraat 9-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10010, "1234AB", "StadA", "Startstraat 10-1", "5678CD", "StadB", "Tostraat 10-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10020, "2233EF", "StadC", "Startstraat 10-2", "8899GH", "StadD", "Tostraat 10-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10011, "1234AB", "StadA", "Startstraat 11-1", "5678CD", "StadB", "Tostraat 11-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10021, "2233EF", "StadC", "Startstraat 11-2", "8899GH", "StadD", "Tostraat 11-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10012, "1234AB", "StadA", "Startstraat 12-1", "5678CD", "StadB", "Tostraat 12-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10022, "2233EF", "StadC", "Startstraat 12-2", "8899GH", "StadD", "Tostraat 12-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10013, "1234AB", "StadA", "Startstraat 13-1", "5678CD", "StadB", "Tostraat 13-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10023, "2233EF", "StadC", "Startstraat 13-2", "8899GH", "StadD", "Tostraat 13-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10014, "1234AB", "StadA", "Startstraat 14-1", "5678CD", "StadB", "Tostraat 14-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10024, "2233EF", "StadC", "Startstraat 14-2", "8899GH", "StadD", "Tostraat 14-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10015, "1234AB", "StadA", "Startstraat 15-1", "5678CD", "StadB", "Tostraat 15-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10025, "2233EF", "StadC", "Startstraat 15-2", "8899GH", "StadD", "Tostraat 15-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10016, "1234AB", "StadA", "Startstraat 16-1", "5678CD", "StadB", "Tostraat 16-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10026, "2233EF", "StadC", "Startstraat 16-2", "8899GH", "StadD", "Tostraat 16-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10017, "1234AB", "StadA", "Startstraat 17-1", "5678CD", "StadB", "Tostraat 17-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10027, "2233EF", "StadC", "Startstraat 17-2", "8899GH", "StadD", "Tostraat 17-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10018, "1234AB", "StadA", "Startstraat 18-1", "5678CD", "StadB", "Tostraat 18-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10028, "2233EF", "StadC", "Startstraat 18-2", "8899GH", "StadD", "Tostraat 18-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10019, "1234AB", "StadA", "Startstraat 19-1", "5678CD", "StadB", "Tostraat 19-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10029, "2233EF", "StadC", "Startstraat 19-2", "8899GH", "StadD", "Tostraat 19-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10020, "1234AB", "StadA", "Startstraat 20-1", "5678CD", "StadB", "Tostraat 20-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10030, "2233EF", "StadC", "Startstraat 20-2", "8899GH", "StadD", "Tostraat 20-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10021, "1234AB", "StadA", "Startstraat 21-1", "5678CD", "StadB", "Tostraat 21-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10031, "2233EF", "StadC", "Startstraat 21-2", "8899GH", "StadD", "Tostraat 21-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10022, "1234AB", "StadA", "Startstraat 22-1", "5678CD", "StadB", "Tostraat 22-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10032, "2233EF", "StadC", "Startstraat 22-2", "8899GH", "StadD", "Tostraat 22-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10023, "1234AB", "StadA", "Startstraat 23-1", "5678CD", "StadB", "Tostraat 23-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10033, "2233EF", "StadC", "Startstraat 23-2", "8899GH", "StadD", "Tostraat 23-2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10024, "1234AB", "StadA", "Startstraat 24-1", "5678CD", "StadB", "Tostraat 24-1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 10034, "2233EF", "StadC", "Startstraat 24-2", "8899GH", "StadD", "Tostraat 24-2" });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2024, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "leenAutos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Kenteken", "KilometerStand" },
                values: new object[] { "AA-123-AA", 10000 });

            migrationBuilder.UpdateData(
                table: "leenAutos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Kenteken",
                value: "BB-234-BB");

            migrationBuilder.UpdateData(
                table: "leenAutos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Kenteken", "KilometerStand" },
                values: new object[] { "CC-345-CC", 30000 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15000, "1234AA", "Startstad", "Startstraat 0", "5678BB", "Bestemmingstad", "Bestemmingstraat 0" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15020, "1234AB", "Startstad B", "Startstraat 0B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 0B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15100, "1234AA", "Startstad", "Startstraat 1", "5678BB", "Bestemmingstad", "Bestemmingstraat 1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15120, "1234AB", "Startstad B", "Startstraat 1B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 1B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15200, "1234AA", "Startstad", "Startstraat 2", "5678BB", "Bestemmingstad", "Bestemmingstraat 2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15220, "1234AB", "Startstad B", "Startstraat 2B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 2B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15300, "1234AA", "Startstad", "Startstraat 3", "5678BB", "Bestemmingstad", "Bestemmingstraat 3" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15320, "1234AB", "Startstad B", "Startstraat 3B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 3B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15400, "1234AA", "Startstad", "Startstraat 4", "5678BB", "Bestemmingstad", "Bestemmingstraat 4" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15420, "1234AB", "Startstad B", "Startstraat 4B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 4B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15500, "1234AA", "Startstad", "Startstraat 5", "5678BB", "Bestemmingstad", "Bestemmingstraat 5" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15520, "1234AB", "Startstad B", "Startstraat 5B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 5B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15600, "1234AA", "Startstad", "Startstraat 6", "5678BB", "Bestemmingstad", "Bestemmingstraat 6" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15620, "1234AB", "Startstad B", "Startstraat 6B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 6B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15700, "1234AA", "Startstad", "Startstraat 7", "5678BB", "Bestemmingstad", "Bestemmingstraat 7" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15720, "1234AB", "Startstad B", "Startstraat 7B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 7B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15000, "1234AA", "Startstad", "Startstraat 0", "5678BB", "Bestemmingstad", "Bestemmingstraat 0" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15020, "1234AB", "Startstad B", "Startstraat 0B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 0B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15100, "1234AA", "Startstad", "Startstraat 1", "5678BB", "Bestemmingstad", "Bestemmingstraat 1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15120, "1234AB", "Startstad B", "Startstraat 1B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 1B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15200, "1234AA", "Startstad", "Startstraat 2", "5678BB", "Bestemmingstad", "Bestemmingstraat 2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15220, "1234AB", "Startstad B", "Startstraat 2B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 2B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15300, "1234AA", "Startstad", "Startstraat 3", "5678BB", "Bestemmingstad", "Bestemmingstraat 3" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15320, "1234AB", "Startstad B", "Startstraat 3B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 3B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15400, "1234AA", "Startstad", "Startstraat 4", "5678BB", "Bestemmingstad", "Bestemmingstraat 4" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15420, "1234AB", "Startstad B", "Startstraat 4B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 4B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15500, "1234AA", "Startstad", "Startstraat 5", "5678BB", "Bestemmingstad", "Bestemmingstraat 5" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15520, "1234AB", "Startstad B", "Startstraat 5B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 5B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15600, "1234AA", "Startstad", "Startstraat 6", "5678BB", "Bestemmingstad", "Bestemmingstraat 6" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15620, "1234AB", "Startstad B", "Startstraat 6B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 6B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15700, "1234AA", "Startstad", "Startstraat 7", "5678BB", "Bestemmingstad", "Bestemmingstraat 7" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15720, "1234AB", "Startstad B", "Startstraat 7B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 7B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15000, "1234AA", "Startstad", "Startstraat 0", "5678BB", "Bestemmingstad", "Bestemmingstraat 0" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15020, "1234AB", "Startstad B", "Startstraat 0B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 0B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15100, "1234AA", "Startstad", "Startstraat 1", "5678BB", "Bestemmingstad", "Bestemmingstraat 1" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15120, "1234AB", "Startstad B", "Startstraat 1B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 1B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15200, "1234AA", "Startstad", "Startstraat 2", "5678BB", "Bestemmingstad", "Bestemmingstraat 2" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15220, "1234AB", "Startstad B", "Startstraat 2B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 2B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15300, "1234AA", "Startstad", "Startstraat 3", "5678BB", "Bestemmingstad", "Bestemmingstraat 3" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15320, "1234AB", "Startstad B", "Startstraat 3B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 3B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15400, "1234AA", "Startstad", "Startstraat 4", "5678BB", "Bestemmingstad", "Bestemmingstraat 4" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15420, "1234AB", "Startstad B", "Startstraat 4B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 4B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15500, "1234AA", "Startstad", "Startstraat 5", "5678BB", "Bestemmingstad", "Bestemmingstraat 5" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15520, "1234AB", "Startstad B", "Startstraat 5B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 5B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15600, "1234AA", "Startstad", "Startstraat 6", "5678BB", "Bestemmingstad", "Bestemmingstraat 6" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15620, "1234AB", "Startstad B", "Startstraat 6B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 6B" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15700, "1234AA", "Startstad", "Startstraat 7", "5678BB", "Bestemmingstad", "Bestemmingstraat 7" });

            migrationBuilder.UpdateData(
                table: "ReserveringData",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "KilometerStand", "StartPostcode", "StartStad", "StartStraat", "ToPostcode", "ToStad", "ToStraat" },
                values: new object[] { 15720, "1234AB", "Startstad B", "Startstraat 7B", "5678BC", "Bestemmingstad B", "Bestemmingstraat 7B" });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 18, 11, 5, 43, 401, DateTimeKind.Local).AddTicks(8136), new DateTime(2025, 5, 16, 11, 5, 43, 401, DateTimeKind.Local).AddTicks(7889), new DateTime(2025, 5, 6, 11, 5, 43, 399, DateTimeKind.Local).AddTicks(456) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2502), new DateTime(2025, 5, 17, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2500), new DateTime(2025, 5, 7, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2598), new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2597), new DateTime(2025, 5, 8, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2642), new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2641), new DateTime(2025, 5, 9, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2664), new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2663), new DateTime(2025, 5, 10, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2661) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2688), new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2687), new DateTime(2025, 5, 11, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2685) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2715), new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2714), new DateTime(2025, 5, 12, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2712) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 25, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2736), new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2735), new DateTime(2025, 5, 13, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2733) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2758), new DateTime(2025, 5, 16, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2756), new DateTime(2025, 5, 6, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2781), new DateTime(2025, 5, 17, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2780), new DateTime(2025, 5, 7, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2779) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2803), new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2802), new DateTime(2025, 5, 8, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2800) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2903), new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2902), new DateTime(2025, 5, 9, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2927), new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2925), new DateTime(2025, 5, 10, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2948), new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2947), new DateTime(2025, 5, 11, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2974), new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2973), new DateTime(2025, 5, 12, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 25, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2998), new DateTime(2025, 5, 13, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3027), new DateTime(2025, 5, 16, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3026), new DateTime(2025, 5, 6, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3056), new DateTime(2025, 5, 17, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3055), new DateTime(2025, 5, 7, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3082), new DateTime(2025, 5, 18, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3081), new DateTime(2025, 5, 8, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3143), new DateTime(2025, 5, 19, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3142), new DateTime(2025, 5, 9, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3140) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3168), new DateTime(2025, 5, 20, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3167), new DateTime(2025, 5, 10, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3194), new DateTime(2025, 5, 21, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3193), new DateTime(2025, 5, 11, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 24, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3219), new DateTime(2025, 5, 22, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3218), new DateTime(2025, 5, 12, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3216) });

            migrationBuilder.UpdateData(
                table: "Reserveringen",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BoekDatumTot", "BoekDatumVanaf", "ReserveerDatum" },
                values: new object[] { new DateTime(2025, 5, 25, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3242), new DateTime(2025, 5, 23, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3241), new DateTime(2025, 5, 13, 11, 5, 43, 402, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "leenAutos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Kenteken", "KilometerStand" },
                values: new object[] { "AB-123-CD", 15000 });

            migrationBuilder.UpdateData(
                table: "leenAutos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Kenteken",
                value: "EF-456-GH");

            migrationBuilder.UpdateData(
                table: "leenAutos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Kenteken", "KilometerStand" },
                values: new object[] { "IJ-789-KL", 25000 });
        }
    }
}
