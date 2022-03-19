using System;
using System.Windows.Forms;
using lib;

namespace Telas
{
    public class MenuDentistaTela : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnDentista;
        Button btnSala;
        Button btnProcedimento;
        Button btnPaciente;
        Button btnAgendamento;
        Button btnEspecialidade;
        Button btnSair;
        public MenuDentistaTela()
        {
            this.lblUser = new Campos.LabelFieldTam("Bem vindo Fulano!", 100, 15, 150, 30);

            btnDentista = new Campos.ButtonField("Dentista", 30, 50, 100, 30);
			btnDentista.Click += new EventHandler(this.btnDentistaClick);

            btnSala = new Campos.ButtonField("Sala", 30, 90, 100, 30);
			btnSala.Click += new EventHandler(this.btnSalaClick);

            btnProcedimento = new Campos.ButtonField("Procedimento", 30, 130, 100, 30);
			btnProcedimento.Click += new EventHandler(this.btnProcedimentoClick);

            btnPaciente = new Campos.ButtonField("Paciente", 170, 50, 100, 30);
			btnPaciente.Click += new EventHandler(this.btnPacienteClick);

            btnAgendamento = new Campos.ButtonField("Agendamento", 170, 90, 100, 30);
			btnAgendamento.Click += new EventHandler(this.btnAgendamentoClick);

            btnEspecialidade = new Campos.ButtonField("Especialidade", 170, 130, 100, 30);
			btnEspecialidade.Click += new EventHandler(this.btnEspecialidadeClick);

            btnSair = new Campos.ButtonField("Sair", 100, 240, 100, 30);
			btnSair.Click += new EventHandler(this.btnSairClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnDentista);
            this.Controls.Add(this.btnSala);
            this.Controls.Add(this.btnProcedimento);
            this.Controls.Add(this.btnPaciente);
            this.Controls.Add(this.btnAgendamento);
            this.Controls.Add(this.btnEspecialidade);
            this.Controls.Add(this.btnSair);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Menu Dentista";
        }

        public void btnSairClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnPacienteClick(object sender, EventArgs e)
        {
            PacienteTela PacienteTelas = new PacienteTela();
            PacienteTelas.ShowDialog();
        }  

        public void btnEspecialidadeClick(object sender, EventArgs e)
        {
            EspacialidadeTela EspacialidadeTelas = new EspacialidadeTela();
            EspacialidadeTelas.ShowDialog();
        } 

        public void btnDentistaClick(object sender, EventArgs e)
        {
            DentistaTela DentistaTelas = new DentistaTela();
            DentistaTelas.ShowDialog();
        }

        public void btnSalaClick(object sender, EventArgs e)
        {
            SalaTela SalaTelas = new SalaTela();
            SalaTelas.ShowDialog();
        }

        public void btnProcedimentoClick(object sender, EventArgs e)
        {
            ProcedimentoTela ProcedimentoTelas = new ProcedimentoTela();
            ProcedimentoTelas.ShowDialog();
        }

        public void btnAgendamentoClick(object sender, EventArgs e)
        {
            AgendamentoTela AgendamentoTelas = new AgendamentoTela();
            AgendamentoTelas.ShowDialog();
        }

    }
}
