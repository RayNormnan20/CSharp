using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabajo1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double  sueldo = 0, descuento = 0, neto = 0;

            if (!string.IsNullOrEmpty(txtCostHora.Text) && !string.IsNullOrEmpty(txtHorTra.Text))
            {
                
                if (double.TryParse(txtCostHora.Text, out double costHora) && double.TryParse(txtHorTra.Text, out double hoTrab))

                sueldo = costHora * hoTrab;
                descuento = sueldo * 10 / 100;
                neto = sueldo - descuento;

                txtSueldo.Text = sueldo.ToString();
                txtAfp.Text = descuento.ToString();
                txtNeto.Text = neto.ToString();

            }
            else
            {
                MessageBox.Show("NO DEBEN EXISTIR ESPACIOS VACIOS", "VENTANA VALIDACIÓN");
                txtEmpleado.Text = "";
                txtCostHora.Text = "";
                txtHorTra.Text = "";
                txtEmpleado.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 ventana5 = new Form5();
            this.Hide();
            ventana5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtEmpleado.Text = "";
            txtCostHora.Text = "";
            txtHorTra.Text = "";
            txtAfp.Text = "";
            txtNeto.Text = "";
            txtSueldo.Text = "";
            txtEmpleado.Focus();
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            Form3 ventana3 = new Form3();

            this.Hide();
            ventana3.Show();
        }
    }
}
