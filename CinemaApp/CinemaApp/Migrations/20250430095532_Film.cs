using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaApp.Migrations
{
    /// <inheritdoc />
    public partial class Film : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Titolo = table.Column<string>(type: "TEXT", nullable: false),
                    DataUscita = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Genere = table.Column<string>(type: "TEXT", nullable: false),
                    Regista = table.Column<string>(type: "TEXT", nullable: false),
                    DurataMinuti = table.Column<int>(type: "INTEGER", nullable: false),
                    Trama = table.Column<string>(type: "TEXT", nullable: false),
                    LocandinaUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Adulti = table.Column<bool>(type: "INTEGER", nullable: false),
                    Valutazione = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}