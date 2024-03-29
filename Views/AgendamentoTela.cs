using System;
using System.Windows.Forms;
using lib;
using Models;
using Controllers;

namespace Telas
{
    public class AgendamentoTela : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnSelect;
        Button btnDelete;
        Button btnUpdate;
        Button btnInsert;
        Button btnVoltar;

        ListView listView;
        public AgendamentoTela()
        {
            this.lblUser = new Campos.LabelFieldTam("AGENDAMENTO", 230, 15, 150, 30);

            btnVoltar = new Campos.ButtonField("Voltar", 50, 400, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnDelete = new Campos.ButtonField("Deletar", 150, 400, 100, 30);
			btnDelete.Click += new EventHandler(this.btnDeleteClick);

            btnUpdate = new Campos.ButtonField("Atualizar", 250, 400, 100, 30);
			//btnConfirmar.Click += new EventHandler(this.btnLogarClick);

            btnInsert = new Campos.ButtonField("Inserir", 350, 400, 100, 30);
			btnInsert.Click += new EventHandler(this.btnInsertClick);

            listView = new Campos.FieldListView(50, 50, 400, 320);
			listView.View = View.Details;
			foreach (Agendamento item in AgendamentoController.VisualizarAgendamentos())
            {
                ListViewItem list = new ListViewItem(item.Id + "");
                list.SubItems.Add(item.Paciente.Nome);	
                list.SubItems.Add(item.Dentista.Nome);
                list.SubItems.Add(item.Sala.Numero);
                list.SubItems.Add(item.Data + "");
                list.SubItems.Add(item.Confirmado + "");
                listView.Items.AddRange(new ListViewItem[]{list});
            }
			listView.Columns.Add("Id", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Paciente", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Dentista", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Sala", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Data", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Confirmado", -2, HorizontalAlignment.Left);
			listView.FullRowSelect = true;
			listView.GridLines = true;
			listView.AllowColumnReorder = true;
			listView.Sorting = SortOrder.Ascending;

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listView);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Agendamento";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnInsertClick(object sender, EventArgs e)
        {
            InsertAgendamentoTela InsertAgendamentoTelas = new InsertAgendamentoTela();
            InsertAgendamentoTelas.ShowDialog();
        }

        public void btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Voce deseja deletar a especialidade?";
            string caption = "Confirmar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Agendamento excluido com sucesso!", "Exclusão");
            }
        }  

    }
}
