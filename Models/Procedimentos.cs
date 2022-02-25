using System;
using System.Collections.Generic;

namespace Models
{
    public class Procedimento
    {
        private static List<Procedimento> Procedimentos = new List<Procedimento>();
        public static int ID = 0;
        public int Id {get; set;}
        public string Descricao {get; set;}
        public double Preco {get; set;}

        public Procedimento(string Descricao,
                            double Preco)
                            :this(++ID, Descricao, Preco)
        {
        }

        private Procedimento(int Id,
                            string Descricao,
                            double Preco)
        {
            this.Id = Id;
            this.Descricao = Descricao;
            this.Preco = Preco;

            Procedimentos.Add(this);
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            if(!Procedimento.ReferenceEquals(obj, this))
            {
                return false;
            }

            Procedimento it = (Procedimento) obj;
            
            return it.Id == this.Id;
        }

        public override string ToString()
        {
            return $"\n Id: {this.Id}" +
                   $"\n Descrição: {this.Descricao}" + 
                   $"\n Preço: {this.Preco}";
        }

        public static List<Procedimento> GetProcedimentos()
        {
            return Procedimentos;
        }

        public static void RemoverProcedimento(Procedimento procedimento)
        {
            Procedimentos.Remove(procedimento);
        }

    }
}