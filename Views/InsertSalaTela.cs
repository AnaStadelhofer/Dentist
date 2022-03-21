using System;
using System.Windows.Forms;
using lib;

namespace Telas
{
    public class InsertSalaTela : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label NumSala;
        TextBox txtNumSala;
        Label EquipSala;
        TextBox txtEquipSala;

        public InsertSalaTela()
        {
            this.lblUser = new Campos.LabelFieldTam("Cadastrar sala", 120, 15, 150, 30);

            this.NumSala = new Campos.LabelField("Número da sala:", 50, 40);
            this.txtNumSala = new Campos.TextBoxField(50, 70, 200, 20);

            this.EquipSala = new Campos.LabelFieldTam("Equipamentos da sala:", 50, 100, 150, 30);
            this.txtEquipSala = new Campos.TextBoxField(50, 130, 200, 20);

            btnVoltar = new Campos.ButtonField("Voltar", 50, 250, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Campos.ButtonField("Salvar", 150, 250, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.NumSala);
            this.Controls.Add(this.EquipSala);
            this.Controls.Add(this.txtNumSala);
            this.Controls.Add(this.txtEquipSala);
            this.Controls.Add(this.btnSalvar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Cadastrar Sala";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            String Message = "Sala atualizada com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}