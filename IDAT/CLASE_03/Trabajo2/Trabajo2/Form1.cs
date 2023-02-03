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
    public partial class frmUno : Form
    {
        public frmUno()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (cbIGV.Checked)
            {
                MessageBox.Show("Los precios SI incluyen iGV", "FACTURA");
            }
            else
            {
                MessageBox.Show("Los precios NO incluyen IGV", "FACTURA");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void frmUno_Load(object sender, EventArgs e)
        {
            cbCorreos.Enabled = false;
            cbPagos.Enabled = false;
        }

        private void cbTerminos_CheckedChanged(object sender, EventArgs e)
        {
            //si la casilla de verificacion pasa de inactivo a activo
            if (cbTerminos.Checked)
            {
                cbCorreos.Enabled = true;
                cbPagos.Enabled = true;
            }
            //si la casilla de verificacion pasa de activo a inactivo
            else
            {
                cbCorreos.Checked = false;
                cbCorreos.Enabled = false;
                cbPagos.Checked = false;
                cbPagos.Enabled = false;
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();

            this.Hide();
            ventana2.Show();
        }
    }
}
