using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CovautoAPI.Domain.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeenAuto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Kenteken = table.Column<string>(type: "TEXT", nullable: false),
                    KilometerStand = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeenAuto", x => x.Id);
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
                name: "Reservingen",
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
                    table.PrimaryKey("PK_Reservingen", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeenAuto");

            migrationBuilder.DropTable(
                name: "ReserveringData");

            migrationBuilder.DropTable(
                name: "Reservingen");
        }
    }
}
