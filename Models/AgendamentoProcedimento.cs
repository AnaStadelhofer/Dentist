using System;
using System.Collections.Generic;
using Repository;
using System.Linq;

namespace Models
{
    public class AgendamentoProcedimento
    {
        public int Id {get; set;}
        
        public int AgendamentoId {get; set;}
        public Agendamento Agendamento {get;}
        public int ProcedimentoId {get; set;}

        public AgendamentoProcedimento()
        {}

        public AgendamentoProcedimento(int AgendamentoId,
                                        int ProcedimentoId)
        {
            this.AgendamentoId = AgendamentoId;
            this.ProcedimentoId = ProcedimentoId;

            Context db = new Context();
            db.AgendamentosProcedimentos.Add(this);
            db.SaveChanges();
        }

        public override string ToString()
        {
            return "\n\n =======================" +
                   "\n Id: " + this.Id +
                   "\n Id Agendamento: " + this.AgendamentoId +
                   "\n Id Procedimento: " + this.ProcedimentoId;
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
            Context db = new Context();
            return (from AgendamentoProcedimento in db.AgendamentosProcedimentos select AgendamentoProcedimento).ToList();
        }

        public static void RemoverAgendamentoProcedimento(AgendamentoProcedimento agendamentoProcedimento)
        {
            Context db = new Context();
            db.AgendamentosProcedimentos.Remove(agendamentoProcedimento);
        }

    }
}