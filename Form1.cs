using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        private string correo;
        private string contras;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this);
            textBox2.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correo = textBox1.Text;
            contras = textBox2.Text;
            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contras))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string correoForm2 = form2.GetCorreo();
                string contraForm2 = form2.GetContra();

                if (correo == correoForm2 && contras == contraForm2)
                {
                    MessageBox.Show("¡Bienvenido!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario no registrado.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
