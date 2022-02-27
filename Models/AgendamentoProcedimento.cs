using System;
using System.Collections.Generic;

namespace Models
{
    public class AgendamentoProcedimento
    {
        public static int ID = 0;
        private static List<AgendamentoProcedimento> AgendamentosProcedimentos = new List<AgendamentoProcedimento>();
        public int Id {get; set;}
        public int IdAgendamento {get; set;}
        public Agendamento Agendamento {get;}
        public int IdProcedimento {get; set;}

        public AgendamentoProcedimento(int IdAgendamento,
                                       int IdProcedimento)
                                       :this(++ID, IdAgendamento, IdProcedimento)
        {}

        private AgendamentoProcedimento(int Id,
                                        int IdAgendamento,
                                        int IdProcedimento)
        {
            this.Id = Id;
            this.IdAgendamento = IdAgendamento;
            this.IdProcedimento = IdProcedimento;

            AgendamentosProcedimentos.Add(this);
        }

        public override string ToString()
        {
            return "\n\n =======================" +
                   "\n Id: " + this.Id +
                   "\n Id Agendamento: " + this.IdAgendamento +
                   "\n Id Procedimento: " + this.IdProcedimento;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }

            if(!AgendamentoProcedimento.ReferenceEquals(obj, this))
            {
                return false;
            }

            AgendamentoProcedimento it = (AgendamentoProcedimento) obj;
            return it.Id == this.Id;

        }

        public static List<AgendamentoProcedimento> GetAgendamentoProcedimentos()
        {
            return AgendamentosProcedimentos;
        }

        public static void RemoverAgendamentoProcedimento(AgendamentoProcedimento agendamentoProcedimento)
        {
            AgendamentosProcedimentos.Remove(agendamentoProcedimento);
        }

    }
}