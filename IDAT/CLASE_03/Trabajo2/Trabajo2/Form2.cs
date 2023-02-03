using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rbPrimaria.Checked = true;
            rbMasculino.Checked = true;
            rbPlanilla.Checked = true;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rbPrimaria.Checked)
            {
                MessageBox.Show("Seleccionó la opción 'Primaria'.", "Opción");
            }
            if (rbSecundaria.Checked)
            {
                MessageBox.Show("Seleccionó la opción 'Secundaria'.", "Opción");
            }
            if (rbSuperior.Checked)
            {
                MessageBox.Show("Seleccionó la opción 'Superior'.", "Opción");
            }

        }

        private void rbSuperior_CheckedChanged(object sender, EventArgs e)
        {
            //si el radiobutton pasa de inactivo a activo
            if (rbSuperior.Checked)
            {
                MessageBox.Show("Seleccionó la opción 'Superior'.", "Opción");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmTres ventana3 = new frmTres();

            this.Hide();
            ventana3.Show();
        }
    }
}
