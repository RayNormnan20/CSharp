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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b100 = 0, b50 = 0, b20 = 0, b5 = 0, b1 = 0;
            if (!string.IsNullOrEmpty(tb_01.Text))
            {

                if (int.TryParse(tb_01.Text, out int cantidad))

                b100 = cantidad / 100;
                cantidad = cantidad % 100;

                b50 = cantidad / 50;
                cantidad = cantidad % 50;

                b20 = cantidad / 20;
                cantidad = cantidad % 20;

                b5 = cantidad / 5;
                cantidad = cantidad % 5;

                b1 = cantidad;

                tb_02.Text = b100.ToString();
                tb_03.Text = b50.ToString();
                tb_04.Text = b20.ToString();
                tb_05.Text = b5.ToString();
                tb_06.Text = b1.ToString();

            }
            else
            {
                MessageBox.Show("DEBES INGRESAR UN DATO", "VENTANA VALIDACIÓN");
            }

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_04_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_01.Text = "";
            tb_02.Text = "";
            tb_03.Text = "";
            tb_04.Text = "";
            tb_05.Text = "";
            tb_06.Text = "";
            tb_01.Focus();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            Form4 ventana4 = new Form4();

            this.Hide();
            ventana4.Show();
        }
    }
}
