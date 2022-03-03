using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultorioOdontologico.Migrations
{
    public partial class _10agendamentid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdDentista",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "IdPaciente",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "IdSala",
                table: "Agendamentos");

            migrationBuilder.AddColumn<int>(
                name: "DentistaId",
                table: "Agendamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PacienteId",
                table: "Agendamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Agendamentos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DentistaId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "PacienteId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Agendamentos");

            migrationBuilder.AddColumn<int>(
                name: "IdDentista",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPaciente",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdSala",
                table: "Agendamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
