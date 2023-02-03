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
    public partial class frmTres : Form
    {
        public frmTres()
        {
            InitializeComponent();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbTipoDocumento.Text, "Tipo de Documento seleccionado");
        }

        private void frmTres_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Text = cmbTipoDocumento.Text;
            //Quitamos los elementos del ComboBox cmbSerie (si es que previamente tenía elementos)
            cmbSerie.Items.Clear();
            //Quitamos el texto que se muestra en el ComboBox (si es que previamente muestra algún texto)
            cmbSerie.Text = "";

            //Si se selecciona "Boleta de Venta"
            if (cmbTipoDocumento.Text.Equals("Boleta de Venta"))
            {
                //Agregamos los elementos de la lista
                cmbSerie.Items.Add("BV01");
                cmbSerie.Items.Add("BV02");
                cmbSerie.Items.Add("BV03");
            }

            //Si se selecciona "Factura"
            if (cmbTipoDocumento.Text.Equals("Factura"))
            {
                cmbSerie.Items.Add("F111");
                cmbSerie.Items.Add("F222");
                cmbSerie.Items.Add("F333");
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbSerie.Text.Length < 1)
            {
                MessageBox.Show("El campo 'Serie' es obligatorio", "Error");
            }

            if (CmbNumero.Text.Length < 1)
            {
                MessageBox.Show("El campo 'Número' es obligatorio", "Error");
            }

            if (cmbSerie.Text.Length > 0 && CmbNumero.Text.Length > 0)
            {
                MessageBox.Show("Datos guardados correctamente.", "Ok");
            }

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmCuatro ventana4 = new frmCuatro();

            this.Hide();
            ventana4.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
