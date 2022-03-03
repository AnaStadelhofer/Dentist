using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Repository;

namespace Models
{
    public class Procedimento
    {
        public int Id {get; set;}
        public string Descricao {get; set;}
        public double Preco {get; set;}

        public Procedimento()
        {
        }

        public Procedimento(string Descricao,
                            double Preco)
        {
            this.Descricao = Descricao;
            this.Preco = Preco;

            Context db = new Context();
            db.Procedimentos.Add(this);
            db.SaveChanges();
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
            return  "\n\n======================= \n"  +
                   $"\n Id: {this.Id}" +
                   $"\n Descrição: {this.Descricao}" + 
                   $"\n Preço: {this.Preco}";
        }

        public static List<Procedimento> GetProcedimentos()
        {
            Context db = new Context();
            return (from Procedimento in db.Procedimentos select Procedimento).ToList();
        }

        public static void RemoverProcedimento(Procedimento procedimento)
        {
            Context db = new Context();
            db.Procedimentos.Remove(procedimento);
        }

    }
}