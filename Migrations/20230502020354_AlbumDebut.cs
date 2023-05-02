using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPdos.Migrations
{
    /// <inheritdoc />
    public partial class AlbumDebut : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlbumDebutId",
                table: "Banda",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AlbumDebutId",
                table: "Artista",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AlbumDebut",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AnioLanzamiento = table.Column<int>(type: "INTEGER", nullable: false),
                    BandaId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumDebut", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Banda_AlbumDebutId",
                table: "Banda",
                column: "AlbumDebutId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Artista_AlbumDebutId",
                table: "Artista",
                column: "AlbumDebutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artista_AlbumDebut_AlbumDebutId",
                table: "Artista",
                column: "AlbumDebutId",
                principalTable: "AlbumDebut",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Banda_AlbumDebut_AlbumDebutId",
                table: "Banda",
                column: "AlbumDebutId",
                principalTable: "AlbumDebut",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artista_AlbumDebut_AlbumDebutId",
                table: "Artista");

            migrationBuilder.DropForeignKey(
                name: "FK_Banda_AlbumDebut_AlbumDebutId",
                table: "Banda");

            migrationBuilder.DropTable(
                name: "AlbumDebut");

            migrationBuilder.DropIndex(
                name: "IX_Banda_AlbumDebutId",
                table: "Banda");

            migrationBuilder.DropIndex(
                name: "IX_Artista_AlbumDebutId",
                table: "Artista");

            migrationBuilder.DropColumn(
                name: "AlbumDebutId",
                table: "Banda");

            migrationBuilder.DropColumn(
                name: "AlbumDebutId",
                table: "Artista");
        }
    }
}
