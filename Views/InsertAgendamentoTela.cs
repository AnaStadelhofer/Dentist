using System;
using System.Windows.Forms;
using lib;
using Models;
using Controllers;

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
        ListView listView;
        Button btnVoltar;
        Button btnSalvar;
        
        public InsertAgendamentoTela()
        {   
            this.lblUser = new Campos.LabelFieldTam("Agendamento", 220, 15, 150, 30);
            this.lblIdPaciente = new Campos.LabelField("Id Paciente:", 50, 40);
            this.txtIdPaciente = new Campos.TextBoxField(50, 70, 180, 20);

            this.lblIdDentista = new Campos.LabelField("Id Dentista:", 50, 100);
            this.txtIdDentista = new Campos.TextBoxField(50, 130, 180, 20);

            this.lblIdSala = new Campos.LabelField("Id Sala:", 50, 160);
            this.txtIdSala = new Campos.TextBoxField(50, 190, 180, 20);

            this.lblData = new Campos.LabelField("Data:", 50, 220);
            this.txtData = new Campos.TextBoxField(50, 250, 180, 20);

            btnVoltar = new Campos.ButtonField("Voltar", 50, 450, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnSalvar = new Campos.ButtonField("Salvar", 350, 450, 100, 30);
			btnSalvar.Click += new EventHandler(this.btnSalvarClick);

            listView = new Campos.FieldListView(50, 280, 400, 150);
			listView.View = View.Details;
            foreach (Paciente item in PacienteController.VisualizarPaciente())
            {
                ListViewItem list = new ListViewItem(item.Id + "");
                list.SubItems.Add(item.Nome);	
                list.SubItems.Add(item.Cpf);
                list.SubItems.Add(item.Fone);
                list.SubItems.Add(item.Email);
                list.SubItems.Add(item.DataNascimento + "");
                listView.Items.AddRange(new ListViewItem[]{list});
            }
			listView.Columns.Add("Id", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
			listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Data de Nascimento", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblIdPaciente);
            this.Controls.Add(this.txtIdPaciente);
            this.Controls.Add(this.lblIdDentista);
            this.Controls.Add(this.lblIdSala);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtIdDentista);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.txtIdSala);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Cadastrar Agendamento";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnSalvarClick(object sender, EventArgs e)
        {
            try
            {
            AgendamentoController.InserirAgendamento(Convert.ToInt32(this.txtIdPaciente.Text), Convert.ToInt32(this.txtIdDentista.Text), Convert.ToInt32(this.txtIdSala.Text), Convert.ToDateTime(this.txtData.Text));
            }
            catch(Exception)
            {
                MessageBox.Show("Erro no cadastro do agendamento", "Erro");
            }
            String Message = "Agendamento cadastrado com sucesso!";
            String Title = "Operação feita!";
            MessageBox.Show(Message, Title);
            this.Close();
        }
    }
}