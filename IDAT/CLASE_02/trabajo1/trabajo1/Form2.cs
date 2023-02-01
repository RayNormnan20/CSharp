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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)


        {
            

            int menor = 0;
            
            if (!string.IsNullOrEmpty(tb_num1.Text) && !string.IsNullOrEmpty(tb_num2.Text) && !string.IsNullOrEmpty(tb_num3.Text)) 

            {   
                if (int.TryParse(tb_num1.Text, out int num1) && int.TryParse(tb_num2.Text, out int num2) && int.TryParse(tb_num3.Text, out int num3))

                if (num1 <= num2 && num1 <= num3)
                {
                    menor = num1;
                }
                else if (num2 <= num1 && num2 <= num3)
                {
                    menor = num2;
                }
                else
                {
                    menor = num3;
                }

                tb_menor.Text = menor.ToString();
            }
            else
            {
                MessageBox.Show("HAY CAMPOS VACIOS", "VENTANA DE VALIDACIÓN");
                tb_num1.Text = "";
                tb_num2.Text = "";
                tb_num3.Text = "";
                tb_num1.Focus();
            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_num1.Text = "";
            tb_num2.Text = "";
            tb_num3.Text = "";
            tb_menor.Text = "";
            tb_num1.Focus();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Form3 ventana3 = new Form3();

            this.Hide();
            ventana3.Show();

        }
    }
}
