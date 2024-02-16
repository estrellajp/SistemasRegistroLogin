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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Verifica si los campos de usuario y contraseña están vacíos
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                // Muestra un mensaje de alerta
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Si ambos campos están llenos, permite el acceso al Form2
                // Por ejemplo, aquí puedes abrir el Form2
                Form2 form2 = new Form2();
                form2.Show();
                // También puedes cerrar este formulario si es necesario
                // this.Close();
            }
        }
    }
}
