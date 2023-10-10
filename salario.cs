using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejerciciosgg.formas
{
    public partial class salario : Form
    {
        public salario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void salario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (decimal.TryParse(txtSalarioActual.Text, out decimal salarioActual) && salarioActual >= 0)
                {
                    decimal incremento = salarioActual * 0.25m; // Incremento del 25%
                    decimal nuevoSalario = salarioActual + incremento;
                    lblNuevoSalario.Text = $"Nuevo salario: {nuevoSalario:C}";
                }
                else
                {
                    MessageBox.Show("Ingrese un salario actual válido y no negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


            private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
