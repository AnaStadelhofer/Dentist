using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultorioOdontologico.Migrations
{
    public partial class _9DentistaId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdEspecialidade",
                table: "Dentistas");

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeId",
                table: "Dentistas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EspecialidadeId",
                table: "Dentistas");

            migrationBuilder.AddColumn<int>(
                name: "IdEspecialidade",
                table: "Dentistas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
