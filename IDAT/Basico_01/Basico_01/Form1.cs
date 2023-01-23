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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bt_suma_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            int total = 0;

            n1 = Convert.ToInt32( Tb_1.Text);
            n2 = Convert.ToInt32( Tb_2.Text);
            total = n1 + n2;

            Tb_3.Text = total.ToString();



        }

        private void Tb_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            int total = 0;

            n1 = Convert.ToInt32(Tb_1.Text);
            n2 = Convert.ToInt32(Tb_2.Text);
            total = n1 * n2;

            Tb_3.Text = total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tb_1.Text = "";
            Tb_2.Text = "";
            Tb_3.Text = "";
            Tb_1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            int total = 0;

            n1 = Convert.ToInt32(Tb_1.Text);
            n2 = Convert.ToInt32(Tb_2.Text);
            total = n1 - n2;

            Tb_3.Text = total.ToString();
        }

        private void Bt_Dividir_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 0;
            Double total = 0;

            n1 = Convert.ToInt32(Tb_1.Text);
            n2 = Convert.ToInt32(Tb_2.Text);
            if (n2 > 0)
            {
                total = n1 / n2;
            }
            

            Tb_3.Text = total.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();

            this.Hide();
            ventana2.Show();

        }

        private void Tb_2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
