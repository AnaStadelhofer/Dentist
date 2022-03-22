using System;
using System.Windows.Forms;
using lib;
using Models;
using Controllers;

namespace Telas
{
    public class DentistaTela : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnSelect;
        Button btnDelete;
        Button btnUpdate;
        Button btnInsert;
        Button btnVoltar;

        ListView listView;
        public DentistaTela()
        {
            this.lblUser = new Campos.LabelFieldTam("DENTISTA", 230, 15, 150, 30);

            btnVoltar = new Campos.ButtonField("Voltar", 50, 400, 100, 30);
			btnVoltar.Click += new EventHandler(this.btnVoltarClick);

            btnDelete = new Campos.ButtonField("Deletar", 150, 400, 100, 30);
			btnDelete.Click += new EventHandler(this.btnDeleteClick);

            btnUpdate = new Campos.ButtonField("Atualizar", 250, 400, 100, 30);
			btnUpdate.Click += new EventHandler(this.btnUpdateClick);

            btnInsert = new Campos.ButtonField("Inserir", 350, 400, 100, 30);
			btnInsert.Click += new EventHandler(this.btnInsertClick);

            listView = new Campos.FieldListView(50, 50, 400, 320);
			listView.View = View.Details;
			foreach(Dentista item in DentistaController.VisualizarDentista())
            {
                ListViewItem list = new ListViewItem(item.Id + "");
                list.SubItems.Add(item.Nome);	
                list.SubItems.Add(item.Cpf + "");
                list.SubItems.Add(item.Fone);
                list.SubItems.Add(item.Email);
                list.SubItems.Add(item.Registro);
                list.SubItems.Add(item.Salario + "");
                list.SubItems.Add(item.EspecialidadeId + "");
                listView.Items.AddRange(new ListViewItem[]{list});
            }
			listView.Columns.Add("Id", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
			listView.Columns.Add("CPF", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Telefone", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Email", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Registro", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Salario", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Especialidade Id", -2, HorizontalAlignment.Left);
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
            this.Text = "Dentista";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnUpdateClick(object sender, EventArgs e)
        {
            UpdateDentistaTela UpdateDentistaTelas = new UpdateDentistaTela();
            UpdateDentistaTelas.ShowDialog();
        } 

        public void btnInsertClick(object sender, EventArgs e)
        {
            InsertDentistaTela InsertDentistaTelas = new InsertDentistaTela();
            InsertDentistaTelas.ShowDialog();
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
                MessageBox.Show("Dentista excluido com sucesso!", "Exclusão");
            }
        }  

    }
}
