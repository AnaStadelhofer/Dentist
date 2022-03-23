using System;
using System.Windows.Forms;
using lib;

namespace Telas
{
    public class InsertAgendamentoTela : Form
    {
        private System.ComponentModel.IContainer components = null;
        TextBox txtIdPaciente;
        TextBox txtIdDentista;
        TextBox txtIdSala;
        TextBox txtData;
        Label lblIdPaciente;
        Label lblIdDentista;
        Label lblIdSala;
        Label lblData;
        Label lblUser;
        
        public InsertAgendamentoTela()
        {   
            this.lblUser = new Campos.LabelFieldTam("Agendamento", 100, 15, 150, 30);
            this.lblIdPaciente = new Campos.LabelField("Id Paciente:", 50, 70);
            this.txtIdPaciente = new Campos.TextBoxField(50, 70, 180, 20);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.txtIdPaciente);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Cadastrar Agndamento";
        }
    }
}