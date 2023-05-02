using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TPdos.Migrations
{
    /// <inheritdoc />
    public partial class Album : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AnioLanzamiento = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AlbumBanda",
                columns: table => new
                {
                    AlbumsId = table.Column<int>(type: "INTEGER", nullable: false),
                    BandasId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumBanda", x => new { x.AlbumsId, x.BandasId });
                    table.ForeignKey(
                        name: "FK_AlbumBanda_Album_AlbumsId",
                        column: x => x.AlbumsId,
                        principalTable: "Album",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumBanda_Banda_BandasId",
                        column: x => x.BandasId,
                        principalTable: "Banda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AlbumBanda_BandasId",
                table: "AlbumBanda",
                column: "BandasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumBanda");

            migrationBuilder.DropTable(
                name: "Album");
        }
    }
}
