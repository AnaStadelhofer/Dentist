using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsultorioOdontologico.Migrations
{
    public partial class _11AgenProId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAgendamento",
                table: "AgendamentosProcedimentos");

            migrationBuilder.DropColumn(
                name: "IdProcedimento",
                table: "AgendamentosProcedimentos");

            migrationBuilder.AddColumn<int>(
                name: "AgendamentoId",
                table: "AgendamentosProcedimentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProcedimentoId",
                table: "AgendamentosProcedimentos",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgendamentoId",
                table: "AgendamentosProcedimentos");

            migrationBuilder.DropColumn(
                name: "ProcedimentoId",
                table: "AgendamentosProcedimentos");

            migrationBuilder.AddColumn<int>(
                name: "IdAgendamento",
                table: "AgendamentosProcedimentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdProcedimento",
                table: "AgendamentosProcedimentos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
