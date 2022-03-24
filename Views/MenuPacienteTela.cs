using System;
using System.Windows.Forms;
using lib;
using Models;
using Controllers;
using System.Drawing;

namespace Telas
{
    public class MenuPacienteTela : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Button btnConfirmarConsulta;
       
        Button btnSair;

        ListView listView;
        public MenuPacienteTela()
        {
            this.BackColor = Color.FromArgb(211, 216, 249);
            this.lblUser = new Campos.LabelFieldTam($"Bem vindo(a), {Auth.Paciente.Nome}!", 100, 15, 150, 30);

            btnConfirmarConsulta = new Campos.ButtonField("Confirmar", 20, 250, 100, 30);
			btnConfirmarConsulta.Click += new EventHandler(this.btnConfirmarConsultaClick);

            btnSair = new Campos.ButtonField("Sair", 180, 250, 100, 30);
			btnSair.Click += new EventHandler(this.btnSairClick);

            listView = new Campos.FieldListView(20, 50, 250, 170);
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
            this.Controls.Add(this.btnConfirmarConsulta);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.btnSair);

            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Menu Paciente";
        }

        public void btnConfirmarConsultaClick(object sender, EventArgs e)
        {
            string message = "Voce deseja confirmar o agendamento?";
            string caption = "Confirmar";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                MessageBox.Show("Agendamento confirmado com sucesso!", "Confirmado");
            }
        }  

        public void btnSairClick(object sender, EventArgs e)
        {
            this.Close();
        }  

    }
}
