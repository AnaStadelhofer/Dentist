using System;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class AgendamentoProcedimentoControllers
    {
        public static AgendamentoProcedimento InsertAgendamentoProcedimento(int IdAgendamento,
                                                                            int IdProcedimento)
        {
            AgendamentoController.GetAgendamento(IdAgendamento);
            ProcedimentoControllers.GetProcedimento(IdProcedimento);
            return new AgendamentoProcedimento(IdAgendamento, IdProcedimento);
        }

        public static AgendamentoProcedimento UpdateAgendamentoProcedimento(int Id,
                                                                            int IdAgendamento,
                                                                            int IdProcedimento)
        {
                AgendamentoProcedimento agendamentoProcedimento = GetAgendamentoProcedimento(Id);
                AgendamentoController.GetAgendamento(IdAgendamento);
                ProcedimentoControllers.GetProcedimento(IdProcedimento);
                
                agendamentoProcedimento.AgendamentoId = IdAgendamento;
                agendamentoProcedimento.ProcedimentoId = IdProcedimento;

                return agendamentoProcedimento;
        }

        public static List<AgendamentoProcedimento> VisualizarAgendamentoProcedimento()
        {
            return AgendamentoProcedimento.GetAgendamentoProcedimentos();
        }

        public static AgendamentoProcedimento DeleteAgendamentoProcedimento(int Id)
        {
            AgendamentoProcedimento agendamentoProcedimento = GetAgendamentoProcedimento(Id);
            AgendamentoProcedimento.RemoverAgendamentoProcedimento(agendamentoProcedimento);
            return agendamentoProcedimento;
        }

        public static AgendamentoProcedimento GetAgendamentoProcedimento(int Id)
        {
            AgendamentoProcedimento agendamentoProcedimento = (
                            from AgendamentoProcedimento in AgendamentoProcedimento.GetAgendamentoProcedimentos()
                                where AgendamentoProcedimento.Id == Id
                                select AgendamentoProcedimento
                        ).First();

            if (agendamentoProcedimento == null)
            {
                throw new Exception("Agendamento / Procedimento não encontrado!");
            }

            return agendamentoProcedimento;
        }
    }
}