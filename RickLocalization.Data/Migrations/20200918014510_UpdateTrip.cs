using Microsoft.EntityFrameworkCore.Migrations;

namespace RickLocalization.Data.Migrations
{
    public partial class UpdateTrip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Morty",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morty", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trip",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDimensao = table.Column<int>(nullable: false),
                    IdRick = table.Column<int>(nullable: false),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trip", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ricks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDimensao = table.Column<int>(nullable: false),
                    IdMorty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ricks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ricks_Dimensions_IdDimensao",
                        column: x => x.IdDimensao,
                        principalTable: "Dimensions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ricks_Morty_IdMorty",
                        column: x => x.IdMorty,
                        principalTable: "Morty",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_IdDimensao",
                table: "Ricks",
                column: "IdDimensao");

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_IdMorty",
                table: "Ricks",
                column: "IdMorty");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ricks");

            migrationBuilder.DropTable(
                name: "Trip");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Morty");
        }
    }
}
