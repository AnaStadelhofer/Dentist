using System;
using System.Windows.Forms;
using lib;

namespace Telas
{
    public class PacienteTela : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnSelect;
        Button btnDelete;
        Button btnUpdate;
        Button btnInsert;
        Button btnVoltar;

        ListView listView;
        public PacienteTela()
        {
            this.lblUser = new Campos.LabelFieldTam("PACIENTE", 230, 15, 150, 30);

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
			ListViewItem PacienteUm = new ListViewItem("1");
			PacienteUm.SubItems.Add("1Amelia");	
			PacienteUm.SubItems.Add("123.123.123-23");
            PacienteUm.SubItems.Add("(47) 9 1234-1234");
            PacienteUm.SubItems.Add("amelia.silva@paciente.com");
            PacienteUm.SubItems.Add("10/10/1998");		
			listView.Items.AddRange(new ListViewItem[]{PacienteUm});
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
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.listView);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Paciente";
        }

        public void btnVoltarClick(object sender, EventArgs e)
        {
            this.Close();
        }
          
        public void btnUpdateClick(object sender, EventArgs e)
        {
            UpdatePacienteTela UpdatePacienteTelas = new UpdatePacienteTela();
            UpdatePacienteTelas.ShowDialog();
        } 
        public void btnInsertClick(object sender, EventArgs e)
        {
            InsertPacienteTela InsertPacienteTelas = new InsertPacienteTela();
            InsertPacienteTelas.ShowDialog();
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
                MessageBox.Show("Paciente excluido com sucesso!", "Exclusão");
            }
        }  
    }
}
