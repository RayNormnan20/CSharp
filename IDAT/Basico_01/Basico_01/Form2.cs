using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basico_01
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Bt_Calcular_Click(object sender, EventArgs e)
        {
            int cantidad = 0;
            double subtotal = 0, igv = 0, total = 0, precio = 0, neto = 0;

            cantidad = Convert.ToInt32(Tb_2.Text);
            precio = Convert.ToInt32(Tb_3.Text);

            subtotal = cantidad * precio;
            igv = subtotal * 0.18;
            total = subtotal + igv;
            neto = total - igv;

            

            Tb_4.Text = total.ToString();
            Tb_5.Text = subtotal.ToString();
            Tb_6.Text = igv.ToString();
            Tb_7.Text = neto.ToString();
                

        
        }

        private void Tb_5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tb_4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bt_Limpiar_Click(object sender, EventArgs e)
        {
            Tb_1.Text = "";
            Tb_2.Text = "";
            Tb_3.Text = "";
            Tb_4.Text = "";
            Tb_5.Text = "";
            Tb_6.Text = "";
            Tb_7.Text = "";
            Tb_1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ventana1 = new Form1();

            this.Hide();
            ventana1.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
