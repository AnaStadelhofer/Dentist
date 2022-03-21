using System;
using System.Windows.Forms;
using lib;

namespace Telas
{
    public class InsertProcedimentoTela : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label DescricaoProcedimento;
        TextBox txtDescricaoProcedimento;
        Label PrecoProcedimento;
        TextBox txtPrecoProcedimento;

        public InsertProcedimentoTela()
        {
            this.lblUser = new Campos.LabelFieldTam("Cadastrar Procedimento", 80, 15, 150, 30);

            this.DescricaoProcedimento = new Campos.LabelField("Descrição:", 50, 40);
            this.txtDescricaoProcedimento = new Campos.TextBoxField(50, 70, 200, 20);

            this.PrecoProcedimento = new Campos.LabelFieldTam("Preço:", 50, 100, 150, 30);
            this.txtPrecoProcedimento = new Campos.TextBoxField(50, 130, 200, 20);

            btnVoltar = new Campos.ButtonField("Voltar", 50, 250, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Campos.ButtonField("Salvar", 150, 250, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.DescricaoProcedimento);
            this.Controls.Add(this.txtDescricaoProcedimento);
            this.Controls.Add(this.PrecoProcedimento);
            this.Controls.Add(this.txtPrecoProcedimento);
            this.Controls.Add(this.btnSalvar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Cadastrar Procedimento";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            String Message = "Procedimento atualizada com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}