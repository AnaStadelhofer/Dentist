using System;
using System.Windows.Forms;
using lib;

namespace Telas
{
    public class SalaTela : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnSelect;
        Button btnDelete;
        Button btnUpdate;
        Button btnInsert;
        Button btnVoltar;

        ListView listView;
        public SalaTela()
        {
            this.lblUser = new Campos.LabelFieldTam("SALA", 230, 15, 150, 30);

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
			ListViewItem filme1 = new ListViewItem("Kill Bill");
			filme1.SubItems.Add("3");
			filme1.SubItems.Add("2001");
			ListViewItem filme2 = new ListViewItem("Rei Leão");
			filme2.SubItems.Add("2");
			filme2.SubItems.Add("1994");
			ListViewItem filme3 = new ListViewItem("Coringa");
			filme3.SubItems.Add("1");	
			filme3.SubItems.Add("2020");		
			listView.Items.AddRange(new ListViewItem[]{filme1, filme2, filme3});
			listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
    		listView.Columns.Add("Estoque", -2, HorizontalAlignment.Left);
			listView.Columns.Add("Ano", -2, HorizontalAlignment.Left);
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
            this.Text = "Sala";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }  

        public void btnUpdateClick(object sender, EventArgs e)
        {
            UpdateSala UpdateSalas = new UpdateSala();
            UpdateSalas.ShowDialog();
        }

        public void btnInsertClick(object sender, EventArgs e)
        {
            InsertSalaTela InsertSalaTelas = new InsertSalaTela();
            InsertSalaTelas.ShowDialog();
        }

        public void btnDeleteClick(object sender, EventArgs e)
        {
            string message = "Voce deseja deletar a sala?";
            string caption = "Confirmar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Sala excluida com sucesso!", "Exclusão");
            }
        }  
    }
}