using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CovautoAPI.API.Migrations
{
    /// <inheritdoc />
    public partial class addonKmAfstandreservering : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "KilometerStand",
                table: "reserveringen",
                newName: "KilometerStandEind");

            migrationBuilder.AddColumn<int>(
                name: "KilometerStandBegin",
                table: "reserveringen",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 1,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 2,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 3,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 4,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 5,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 6,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 7,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 8,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 9,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 10,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 11,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 12,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 13,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 14,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 15,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 16,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 17,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 18,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 19,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 20,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 21,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 22,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 23,
                column: "KilometerStandBegin",
                value: null);

            migrationBuilder.UpdateData(
                table: "reserveringen",
                keyColumn: "Id",
                keyValue: 24,
                column: "KilometerStandBegin",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KilometerStandBegin",
                table: "reserveringen");

            migrationBuilder.RenameColumn(
                name: "KilometerStandEind",
                table: "reserveringen",
                newName: "KilometerStand");
        }
    }
}
