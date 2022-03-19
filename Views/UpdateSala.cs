using System;
using System.Windows.Forms;
using lib;

namespace Telas
{
    public class UpdateSala : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnVoltar;

        Label IdSala;
        TextBox txtIdSala;
        Label NumSala;
        TextBox txtNumSala;
        Label EquipSala;
        TextBox txtEquipSala;

        public UpdateSala()
        {
            this.lblUser = new Campos.LabelFieldTam("Atualizar sala", 130, 15, 150, 30);

            this.IdSala = new Campos.LabelField("Id da sala:", 50, 40);
            this.txtIdSala = new Campos.TextBoxField(50, 70, 180, 20);

            this.NumSala = new Campos.LabelField("Número da sala:", 50, 100);
            this.txtNumSala = new Campos.TextBoxField(50, 130, 180, 20);

            this.EquipSala = new Campos.LabelField("Equipamentos da sala:", 50, 160);
            this.txtEquipSala = new Campos.TextBoxField(50, 190, 180, 20);

            btnVoltar = new Campos.ButtonField("Voltar", 50, 250, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.IdSala);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.NumSala);
            this.Controls.Add(this.EquipSala);
            this.Controls.Add(this.txtIdSala);
            this.Controls.Add(this.txtNumSala);
            this.Controls.Add(this.txtEquipSala);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Sala";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

    }  

}
