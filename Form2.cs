using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        private string nombre;
        private string correoElectronico;
        private string contra;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            nombre = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CompararContrasenas()
        {
            if (textBox3.Text == textBox4.Text)
            {
                // Si coinciden, marcamos el checkBox1 como seleccionado (checked)
                checkBox1.Checked = true;
            }
            else
            {
                // Si no coinciden, desmarcamos el checkBox1
                checkBox1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correoElectronico = textBox2.Text;
            contra = textBox3.Text;

            MessageBox.Show("Registro exitoso!");
        }
    }
}
