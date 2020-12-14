using Microsoft.EntityFrameworkCore.Migrations;

namespace ProAgil.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "eventos",
                columns: table => new
                {
                    eventoid = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    local = table.Column<string>(nullable: true),
                    dataevento = table.Column<string>(nullable: true),
                    tema = table.Column<string>(nullable: true),
                    quantidadepessoas = table.Column<int>(nullable: false),
                    lote = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_eventos", x => x.eventoid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "eventos");
        }
    }
}
