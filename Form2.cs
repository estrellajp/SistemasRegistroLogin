using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private string correoElectronico;
        private string contra;
        private Form1 form1;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correoElectronico = textBox2.Text;
            contra = textBox3.Text;
            MessageBox.Show("¡Registro exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            form1.Show();
            this.Hide();
        }

        public string GetCorreo()
        {
            return correoElectronico;
        }

        public string GetContra()
        {
            return contra;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CompararContrasenas();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            contra = textBox3.Text;
            CompararContrasenas();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            correoElectronico = textBox2.Text;
        }

        private void CompararContrasenas()
        {
            if (textBox3.Text == textBox4.Text)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }
    }
}
