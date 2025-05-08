using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CinemaApp.Migrations
{
    /// <inheritdoc />
    public partial class BigliettoPostoProiezioneSala : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    CapacitaPosti = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Fila = table.Column<string>(type: "TEXT", nullable: false),
                    Numero = table.Column<int>(type: "INTEGER", nullable: false),
                    SalaId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posti_Sale_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Proiezioni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FilmId = table.Column<int>(type: "INTEGER", nullable: false),
                    SalaId = table.Column<int>(type: "INTEGER", nullable: false),
                    DataOra = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PrezzoBase = table.Column<decimal>(type: "TEXT", nullable: false),
                    Attiva = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proiezioni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proiezioni_Films_FilmId",
                        column: x => x.FilmId,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Proiezioni_Sale_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Sale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Biglietti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProiezioneId = table.Column<int>(type: "INTEGER", nullable: false),
                    PostoId = table.Column<int>(type: "INTEGER", nullable: true),
                    PrezzoFinale = table.Column<decimal>(type: "TEXT", nullable: false),
                    CodicePrenotazione = table.Column<string>(type: "TEXT", nullable: true),
                    DataAcquisto = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmailCliente = table.Column<string>(type: "TEXT", nullable: true),
                    Utilizzato = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biglietti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Biglietti_Posti_PostoId",
                        column: x => x.PostoId,
                        principalTable: "Posti",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Biglietti_Proiezioni_ProiezioneId",
                        column: x => x.ProiezioneId,
                        principalTable: "Proiezioni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biglietti_PostoId",
                table: "Biglietti",
                column: "PostoId");

            migrationBuilder.CreateIndex(
                name: "IX_Biglietti_ProiezioneId",
                table: "Biglietti",
                column: "ProiezioneId");

            migrationBuilder.CreateIndex(
                name: "IX_Posti_SalaId",
                table: "Posti",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Proiezioni_FilmId",
                table: "Proiezioni",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_Proiezioni_SalaId",
                table: "Proiezioni",
                column: "SalaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Biglietti");

            migrationBuilder.DropTable(
                name: "Posti");

            migrationBuilder.DropTable(
                name: "Proiezioni");

            migrationBuilder.DropTable(
                name: "Sale");
        }
    }
}
