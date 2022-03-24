using System;
using System.Windows.Forms;
using lib;
using Controllers;

namespace Telas
{
    public class InsertDentistaTela : Form
    {
        private System.ComponentModel.IContainer components = null;
        Label lblUser;
        Button btnVoltar;
        Button btnSalvar;
        Label Nome;
        Label CPF;
        Label Telefone;
        Label Email;
        Label DataNascimento;
        Label Senha;
        Label Registro;
        Label Salario;
        Label EspecialidadeId;
        TextBox txtNome;
        TextBox txtCPF;
        TextBox txtTelefone;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtRegistro;
        TextBox txtSalario;
        TextBox txtEspecialidadeId;
        ListView listView;
 
        public InsertDentistaTela()
        {
            this.lblUser = new Campos.LabelFieldTam("Cadastrar Dentista", 200, 15, 150, 30);

            this.Nome = new Campos.LabelFieldTam("Nome:", 50, 40, 150, 30);
            this.txtNome = new Campos.TextBoxField(50, 70, 180, 20);

            this.CPF = new Campos.LabelField("CPF:", 50, 100);
            this.txtCPF = new Campos.TextBoxField(50, 130, 180, 20);

            this.Telefone = new Campos.LabelFieldTam("Telefone:", 50, 160, 150, 30);
            this.txtTelefone = new Campos.TextBoxField(50, 190, 180, 20);

            this.Email = new Campos.LabelFieldTam("Email:", 50, 220, 150, 30);
            this.txtEmail = new Campos.TextBoxField(50, 250, 180, 20);

            // Nova Coluna

            this.Registro = new Campos.LabelFieldTam("Registro:", 250, 40, 150, 30);
            this.txtRegistro = new Campos.TextBoxField(250, 70, 180, 20);

            this.Salario = new Campos.LabelFieldTam("Salario:", 250, 100, 150, 30);
            this.txtSalario = new Campos.TextBoxField(250, 130, 180, 20);

            this.EspecialidadeId = new Campos.LabelFieldTam("Especialidade Id:", 250, 160, 150, 30);
            this.txtEspecialidadeId = new Campos.TextBoxField(250, 190, 180, 20);

            this.Senha = new Campos.LabelFieldTam("Senha:", 250, 220, 150, 30);
            this.txtSenha = new Campos.TextBoxField(250, 250, 180, 20);

            listView = new Campos.FieldListView(50, 350, 380, 80);
			listView.View = View.Details;
			ListViewItem EspecialidadeUm = new ListViewItem("1");
			EspecialidadeUm.SubItems.Add("Limpar sala e dente do paciente");
			EspecialidadeUm.SubItems.Add("Limpar sala");
			listView.Items.AddRange(new ListViewItem[]{EspecialidadeUm});
			listView.Columns.Add("Id", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Descrição", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Tarefas", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;

            btnVoltar = new Campos.ButtonField("Voltar", 50, 450, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Campos.ButtonField("Salvar", 330, 450, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.Registro);
            this.Controls.Add(this.txtRegistro);
            this.Controls.Add(this.Salario);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.EspecialidadeId);
            this.Controls.Add(this.txtEspecialidadeId);
            this.Controls.Add(this.listView);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Cadastrar Dentista";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            try
            {
                DentistaController.InserirDentista(this.txtNome.Text, this.txtCPF.Text, this.txtTelefone.Text, this.txtEmail.Text, this.txtSenha.Text, this.txtRegistro.Text, Convert.ToDouble(this.txtSalario.Text), Convert.ToInt32(this.txtEspecialidadeId.Text));
            }
            catch(Exception)
            {
                MessageBox.Show("Preencha todos os campos!", "Erro");
            }
            String Message = "Dentista cadastrado com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}