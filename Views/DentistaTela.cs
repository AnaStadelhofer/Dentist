using System;
using System.Windows.Forms;
using lib;

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
			ListViewItem Dentista1 = new ListViewItem("1");
			Dentista1.SubItems.Add("José");
			Dentista1.SubItems.Add("123-123-123-12");	
            Dentista1.SubItems.Add("(47) 9 1234-1234");	
            Dentista1.SubItems.Add("jose.carmo@dentista.com");	
            Dentista1.SubItems.Add("12345/sc");		
            Dentista1.SubItems.Add("2 k");	
            Dentista1.SubItems.Add("1");	
			listView.Items.AddRange(new ListViewItem[]{Dentista1});
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
