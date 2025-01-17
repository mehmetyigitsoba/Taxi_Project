using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Taxi_Project.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ils",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ils", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ilces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ilces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ilces_Ils_IlId",
                        column: x => x.IlId,
                        principalTable: "Ils",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Semts_Ilces_IlceId",
                        column: x => x.IlceId,
                        principalTable: "Ilces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mahalles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SemtId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mahalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mahalles_Semts_SemtId",
                        column: x => x.SemtId,
                        principalTable: "Semts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    İl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    semt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    mahalle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IlId = table.Column<int>(type: "int", nullable: false),
                    IlceId = table.Column<int>(type: "int", nullable: false),
                    SemtId = table.Column<int>(type: "int", nullable: false),
                    MahalleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musteris_Mahalles_MahalleId",
                        column: x => x.MahalleId,
                        principalTable: "Mahalles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Randevus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    hesapTutari = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Randevus_Musteris_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Musteris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ilces_IlId",
                table: "Ilces",
                column: "IlId");

            migrationBuilder.CreateIndex(
                name: "IX_Mahalles_SemtId",
                table: "Mahalles",
                column: "SemtId");

            migrationBuilder.CreateIndex(
                name: "IX_Musteris_MahalleId",
                table: "Musteris",
                column: "MahalleId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevus_MusteriId",
                table: "Randevus",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Semts_IlceId",
                table: "Semts",
                column: "IlceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Randevus");

            migrationBuilder.DropTable(
                name: "Musteris");

            migrationBuilder.DropTable(
                name: "Mahalles");

            migrationBuilder.DropTable(
                name: "Semts");

            migrationBuilder.DropTable(
                name: "Ilces");

            migrationBuilder.DropTable(
                name: "Ils");
        }
    }
}
