using System.Drawing;
using System.Windows.Forms;

namespace Telas
{
    public class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;

        Label lblUser;
        Label lblPassword;
        TextBox txtUser;
        TextBox txtPass;

        Button btnConfirmar;
        Button btnCancelar;
        public Form1()
        {
            this.lblUser = new LabelField("Usuário", 120, 30);

            this.txtUser = new TextBox();
            this.txtUser.Location = new Point(60, 60);
            this.txtUser.Size = new Size(180, 20);


            this.lblPassword = new Label();
            this.lblPassword.Text = "Senha";
            this.lblPassword.Location = new Point(120, 100);

            this.txtPass = new TextBox();
            this.txtPass.Location = new Point(60, 130);
            this.txtPass.Size = new Size(180, 20);
            //this.txtPass.PasswordChar = "*";

            btnConfirmar = new Button();
			btnConfirmar.Text = "Confirmar";
			btnConfirmar.Size = new Size(100,30);
			btnConfirmar.Location = new Point(100, 180);
			//btnConfirmar.Click += new EventHandler(this.btnConfirmarClick);

			btnCancelar = new Button();
			btnCancelar.Text = "Cancelar";
			btnCancelar.Size = new Size(100,30);
			btnCancelar.Location = new Point(100, 220);
			//btnCancelar.Click += new EventHandler(this.btnCancelarClick);

            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Text = "Form1";
        }

        public class LabelField : Label
        {
            public LabelField(string Text, int x, int y)
            {
                this.Text = Text;
                this.Location = new Point(x, y);
            }
        }

    }
}
