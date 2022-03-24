using System;
using System.Windows.Forms;
using lib;
using Controllers;

namespace Telas
{
    public class UpdateSala : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label IdSala;
        TextBox txtIdSala;
        Label NumSala;
        TextBox txtNumSala;
        Label EquipSala;
        TextBox txtEquipSala;

        public UpdateSala()
        {
            this.lblUser = new Campos.LabelFieldTam("Atualizar sala", 120, 15, 150, 30);

            this.IdSala = new Campos.LabelField("Id da sala:", 50, 40);
            this.txtIdSala = new Campos.TextBoxField(50, 70, 200, 20);

            this.NumSala = new Campos.LabelField("Número da sala:", 50, 100);
            this.txtNumSala = new Campos.TextBoxField(50, 130, 200, 20);

            this.EquipSala = new Campos.LabelFieldTam("Equipamentos da sala:", 50, 160, 150, 30);
            this.txtEquipSala = new Campos.TextBoxField(50, 190, 200, 20);

            btnVoltar = new Campos.ButtonField("Voltar", 50, 250, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Campos.ButtonField("Salvar", 150, 250, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.IdSala);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.NumSala);
            this.Controls.Add(this.EquipSala);
            this.Controls.Add(this.txtIdSala);
            this.Controls.Add(this.txtNumSala);
            this.Controls.Add(this.txtEquipSala);
            this.Controls.Add(this.btnSalvar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Atualizar Sala";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            SalaController.AlterarSala(Convert.ToInt32(this.txtIdSala.Text), this.txtNumSala.Text, this.txtEquipSala.Text);
            String Message = "Sala atualizada com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }  
}