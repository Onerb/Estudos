using Microsoft.EntityFrameworkCore.Migrations;

namespace MinhaAppVS.Migrations
{
    public partial class retiraendereco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "endereco",
                table: "Alunos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "endereco",
                table: "Alunos",
                nullable: true);
        }
    }
}
