using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Avaliacao.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RickMory",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    RickNome = table.Column<string>(nullable: true),
                    MortyNome = table.Column<string>(nullable: true),
                    Dimensao = table.Column<string>(nullable: true),
                    ImagemRick = table.Column<byte[]>(nullable: true),
                    ImagemMorty = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RickMory", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RickMory");
        }
    }
}
