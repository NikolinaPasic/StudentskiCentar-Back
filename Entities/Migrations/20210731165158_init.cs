using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentskiCentar",
                columns: table => new
                {
                    StudentskiCentarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentskiCentar", x => x.StudentskiCentarId);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    AdministratorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumZaposlenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentskiCentarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.AdministratorId);
                    table.ForeignKey(
                        name: "FK_Administrator_StudentskiCentar_StudentskiCentarId",
                        column: x => x.StudentskiCentarId,
                        principalTable: "StudentskiCentar",
                        principalColumn: "StudentskiCentarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentskiDom",
                columns: table => new
                {
                    StudentskiDomId = table.Column<int>(type: "int", nullable: false),
                    StudentskiCentarId = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentskiDom", x => new { x.StudentskiCentarId, x.StudentskiDomId });
                    table.ForeignKey(
                        name: "FK_StudentskiDom_StudentskiCentar_StudentskiCentarId",
                        column: x => x.StudentskiCentarId,
                        principalTable: "StudentskiCentar",
                        principalColumn: "StudentskiCentarId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Blok",
                columns: table => new
                {
                    BlokId = table.Column<int>(type: "int", nullable: false),
                    StudentskiCentarId = table.Column<int>(type: "int", nullable: false),
                    StudentskiDomId = table.Column<int>(type: "int", nullable: false),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blok", x => new { x.StudentskiCentarId, x.StudentskiDomId, x.BlokId });
                    table.ForeignKey(
                        name: "FK_Blok_StudentskiCentar_StudentskiCentarId",
                        column: x => x.StudentskiCentarId,
                        principalTable: "StudentskiCentar",
                        principalColumn: "StudentskiCentarId");
                    table.ForeignKey(
                        name: "FK_Blok_StudentskiDom_StudentskiCentarId_StudentskiDomId",
                        columns: x => new { x.StudentskiCentarId, x.StudentskiDomId },
                        principalTable: "StudentskiDom",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId" });
                });

            migrationBuilder.CreateTable(
                name: "Masina",
                columns: table => new
                {
                    MasinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kapacitet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentskiDomStudentskiCentarId = table.Column<int>(type: "int", nullable: false),
                    StudentskiDomId1 = table.Column<int>(type: "int", nullable: false),
                    StudentskiDomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masina", x => x.MasinaId);
                    table.ForeignKey(
                        name: "FK_Masina_StudentskiDom_StudentskiDomStudentskiCentarId_StudentskiDomId1",
                        columns: x => new { x.StudentskiDomStudentskiCentarId, x.StudentskiDomId1 },
                        principalTable: "StudentskiDom",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sobe",
                columns: table => new
                {
                    BrojSobe = table.Column<int>(type: "int", nullable: false),
                    StudentskiCentarId = table.Column<int>(type: "int", nullable: false),
                    StudentskiDomId = table.Column<int>(type: "int", nullable: false),
                    BlokId = table.Column<int>(type: "int", nullable: false),
                    Kategorija = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sobe", x => new { x.StudentskiCentarId, x.StudentskiDomId, x.BlokId, x.BrojSobe });
                    table.ForeignKey(
                        name: "FK_Sobe_Blok_StudentskiCentarId_StudentskiDomId_BlokId",
                        columns: x => new { x.StudentskiCentarId, x.StudentskiDomId, x.BlokId },
                        principalTable: "Blok",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId", "BlokId" });
                    table.ForeignKey(
                        name: "FK_Sobe_StudentskiCentar_StudentskiCentarId",
                        column: x => x.StudentskiCentarId,
                        principalTable: "StudentskiCentar",
                        principalColumn: "StudentskiCentarId");
                    table.ForeignKey(
                        name: "FK_Sobe_StudentskiDom_StudentskiCentarId_StudentskiDomId",
                        columns: x => new { x.StudentskiCentarId, x.StudentskiDomId },
                        principalTable: "StudentskiDom",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId" });
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojIndeksa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PozivNaBroj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrojDorucaka = table.Column<int>(type: "int", nullable: false),
                    BrojRucaka = table.Column<int>(type: "int", nullable: false),
                    BrojVecera = table.Column<int>(type: "int", nullable: false),
                    Finansiranje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StanjeNaRacunu = table.Column<double>(type: "float", nullable: false),
                    BrojSobe = table.Column<int>(type: "int", nullable: false),
                    StudentskiDomStudentskiCentarId = table.Column<int>(type: "int", nullable: false),
                    StudentskiDomId1 = table.Column<int>(type: "int", nullable: false),
                    StudentskiCentarId = table.Column<int>(type: "int", nullable: false),
                    StudentskiDomId = table.Column<int>(type: "int", nullable: false),
                    BlokStudentskiCentarId = table.Column<int>(type: "int", nullable: false),
                    BlokStudentskiDomId = table.Column<int>(type: "int", nullable: false),
                    BlokId1 = table.Column<int>(type: "int", nullable: false),
                    BlokId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Blok_BlokStudentskiCentarId_BlokStudentskiDomId_BlokId1",
                        columns: x => new { x.BlokStudentskiCentarId, x.BlokStudentskiDomId, x.BlokId1 },
                        principalTable: "Blok",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId", "BlokId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_Sobe_BrojSobe_StudentskiDomId_StudentskiCentarId_BlokId",
                        columns: x => new { x.BrojSobe, x.StudentskiDomId, x.StudentskiCentarId, x.BlokId },
                        principalTable: "Sobe",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId", "BlokId", "BrojSobe" });
                    table.ForeignKey(
                        name: "FK_Student_StudentskiCentar_StudentskiCentarId",
                        column: x => x.StudentskiCentarId,
                        principalTable: "StudentskiCentar",
                        principalColumn: "StudentskiCentarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Student_StudentskiDom_StudentskiDomStudentskiCentarId_StudentskiDomId1",
                        columns: x => new { x.StudentskiDomStudentskiCentarId, x.StudentskiDomId1 },
                        principalTable: "StudentskiDom",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId" },
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Rezervacija",
                columns: table => new
                {
                    Termin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    MasinaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervacija", x => new { x.Termin, x.StudentId, x.MasinaId });
                    table.ForeignKey(
                        name: "FK_Rezervacija_Masina_MasinaId",
                        column: x => x.MasinaId,
                        principalTable: "Masina",
                        principalColumn: "MasinaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervacija_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Uplata",
                columns: table => new
                {
                    UplataId = table.Column<int>(type: "int", nullable: false),
                    AdministratorId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    SvrhaUplate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Iznos = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uplata", x => new { x.StudentId, x.AdministratorId, x.UplataId });
                    table.ForeignKey(
                        name: "FK_Uplata_Administrator_AdministratorId",
                        column: x => x.AdministratorId,
                        principalTable: "Administrator",
                        principalColumn: "AdministratorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Uplata_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UplataStanarine",
                columns: table => new
                {
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    BrojSobe = table.Column<int>(type: "int", nullable: false),
                    StudentskiCentarId = table.Column<int>(type: "int", nullable: false),
                    StudentskiDomId = table.Column<int>(type: "int", nullable: false),
                    BlokId = table.Column<int>(type: "int", nullable: false),
                    Iznos = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UplataStanarine", x => new { x.Datum, x.BrojSobe, x.BlokId, x.StudentskiDomId, x.StudentskiCentarId, x.StudentId });
                    table.ForeignKey(
                        name: "FK_UplataStanarine_Blok_StudentskiCentarId_StudentskiDomId_BlokId",
                        columns: x => new { x.StudentskiCentarId, x.StudentskiDomId, x.BlokId },
                        principalTable: "Blok",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId", "BlokId" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UplataStanarine_Sobe_BrojSobe_StudentskiCentarId_StudentskiDomId_BlokId",
                        columns: x => new { x.BrojSobe, x.StudentskiCentarId, x.StudentskiDomId, x.BlokId },
                        principalTable: "Sobe",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId", "BlokId", "BrojSobe" });
                    table.ForeignKey(
                        name: "FK_UplataStanarine_Student_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Student",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_UplataStanarine_StudentskiCentar_StudentskiCentarId",
                        column: x => x.StudentskiCentarId,
                        principalTable: "StudentskiCentar",
                        principalColumn: "StudentskiCentarId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UplataStanarine_StudentskiDom_StudentskiCentarId_StudentskiDomId",
                        columns: x => new { x.StudentskiCentarId, x.StudentskiDomId },
                        principalTable: "StudentskiDom",
                        principalColumns: new[] { "StudentskiCentarId", "StudentskiDomId" },
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_StudentskiCentarId",
                table: "Administrator",
                column: "StudentskiCentarId");

            migrationBuilder.CreateIndex(
                name: "IX_Masina_StudentskiDomStudentskiCentarId_StudentskiDomId1",
                table: "Masina",
                columns: new[] { "StudentskiDomStudentskiCentarId", "StudentskiDomId1" });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_MasinaId",
                table: "Rezervacija",
                column: "MasinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_StudentId",
                table: "Rezervacija",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_BlokStudentskiCentarId_BlokStudentskiDomId_BlokId1",
                table: "Student",
                columns: new[] { "BlokStudentskiCentarId", "BlokStudentskiDomId", "BlokId1" });

            migrationBuilder.CreateIndex(
                name: "IX_Student_BrojSobe_StudentskiDomId_StudentskiCentarId_BlokId",
                table: "Student",
                columns: new[] { "BrojSobe", "StudentskiDomId", "StudentskiCentarId", "BlokId" });

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentskiCentarId",
                table: "Student",
                column: "StudentskiCentarId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudentskiDomStudentskiCentarId_StudentskiDomId1",
                table: "Student",
                columns: new[] { "StudentskiDomStudentskiCentarId", "StudentskiDomId1" });

            migrationBuilder.CreateIndex(
                name: "IX_Uplata_AdministratorId",
                table: "Uplata",
                column: "AdministratorId");

            migrationBuilder.CreateIndex(
                name: "IX_UplataStanarine_BrojSobe_StudentskiCentarId_StudentskiDomId_BlokId",
                table: "UplataStanarine",
                columns: new[] { "BrojSobe", "StudentskiCentarId", "StudentskiDomId", "BlokId" });

            migrationBuilder.CreateIndex(
                name: "IX_UplataStanarine_StudentId",
                table: "UplataStanarine",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_UplataStanarine_StudentskiCentarId_StudentskiDomId_BlokId",
                table: "UplataStanarine",
                columns: new[] { "StudentskiCentarId", "StudentskiDomId", "BlokId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rezervacija");

            migrationBuilder.DropTable(
                name: "Uplata");

            migrationBuilder.DropTable(
                name: "UplataStanarine");

            migrationBuilder.DropTable(
                name: "Masina");

            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Sobe");

            migrationBuilder.DropTable(
                name: "Blok");

            migrationBuilder.DropTable(
                name: "StudentskiDom");

            migrationBuilder.DropTable(
                name: "StudentskiCentar");
        }
    }
}
