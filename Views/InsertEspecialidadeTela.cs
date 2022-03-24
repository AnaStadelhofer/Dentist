using System;
using System.Windows.Forms;
using lib;
using Controllers;

namespace Telas
{
    public class InsertEspecialidadeTela : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label DescricaoEspecialidade;
        TextBox txtDescricaoEspecialidade;
        Label TarefaEspecialidade;
        TextBox txtTarefaEspecialidade;

        public InsertEspecialidadeTela()
        {
            this.lblUser = new Campos.LabelFieldTam("Cadastrar Especialidade", 80, 15, 150, 30);

            this.DescricaoEspecialidade = new Campos.LabelFieldTam("Descrição:", 50, 40, 150, 30);
            this.txtDescricaoEspecialidade = new Campos.TextBoxField(50, 70, 200, 20);

            this.TarefaEspecialidade = new Campos.LabelField("Tarefas:", 50, 100);
            this.txtTarefaEspecialidade = new Campos.TextBoxField(50, 130, 200, 20);

            btnVoltar = new Campos.ButtonField("Voltar", 50, 250, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Campos.ButtonField("Salvar", 150, 250, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.DescricaoEspecialidade);
            this.Controls.Add(this.txtDescricaoEspecialidade);
            this.Controls.Add(this.TarefaEspecialidade);
            this.Controls.Add(this.txtTarefaEspecialidade);
            this.Controls.Add(this.btnSalvar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Cadastrar Especialidade";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                EspecialidadeController.InsertEspecialidade(this.txtDescricaoEspecialidade.Text, this.txtTarefaEspecialidade.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro");
            }
            String Message = "Especialidade cadastrada com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}