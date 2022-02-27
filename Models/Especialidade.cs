using System;
using System.Collections.Generic;

namespace Models
{
    public class Especialidade
    {
        public static int ID = 0;
        public int Id {get; set;}
        public string Descricao {get; set;}
        public string Tarefas {get; set;}
        private static List<Especialidade> Especialidades = new List<Especialidade>();
        
        public Especialidade(string Descricao,
                              string Tarefas) :
                              this(++ID, Descricao, Tarefas)
        {
        }
        private Especialidade(int Id,
                             string Descricao,
                             string Tarefas)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Tarefas = Tarefas;

            Especialidades.Add(this);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!Especialidade.ReferenceEquals(obj, this))
            {
                return false;
            }
            Especialidade it = (Especialidade) obj;
            return it.Id == this.Id;
        }

        public override string ToString()
        {
            return "\n\n======================= \n" 
                + $"ID: {this.Id}"
                + $"\n Descrição: {this.Descricao}"
                + $"\n Tarefas: {this.Tarefas}";
        }

        public static List<Especialidade> GetEspecialidades()
        {
            return Especialidades;
        }

        public static void RemoverEspecialidade(Especialidade especialidade)
        {
            Especialidades.Remove(especialidade);
        }

    }
}