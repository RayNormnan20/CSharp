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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tb_mesDia.Text = "";
            tb_dia.Text = "";
            tb_Signo.Text = "";
            tb_mesDia.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 ventana4 = new Form4();

            this.Hide();
            ventana4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int mes = Convert.ToInt32(tb_mesDia.Text);
            //int dia = Convert.ToInt32(tb_dia.Text);

            if (!string.IsNullOrEmpty(tb_mesDia.Text) && !string.IsNullOrEmpty(tb_dia.Text))
            {
                string signo = "";
                if (int.TryParse(tb_mesDia.Text, out int mes) && int.TryParse(tb_dia.Text, out int dia) )  

                if (mes == 3 && dia >= 21 || mes == 4 && dia <= 19)
                {
                    signo = "Aries";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 4 && dia >= 20 || mes == 5 && dia <= 20)
                {
                    signo = "Tauro";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 5 && dia >= 21 || mes == 6 && dia <= 20)
                {
                    signo = "Géminis";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 6 && dia >= 21 || mes == 7 && dia <= 22)
                {
                    signo = "Cáncer";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 7 && dia >= 23 || mes == 8 && dia <= 22)
                {
                    signo = "Leo";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 8 && dia >= 23 || mes == 9 && dia <= 22)
                {
                    signo = "Virgo";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 9 && dia >= 23 || mes == 10 && dia <= 22)
                {
                    signo = "Libra";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 10 && dia >= 23 || mes == 11 && dia <= 21)
                {
                    signo = "Escorpio";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 11 && dia >= 22 || mes == 12 && dia <= 21)
                {
                    signo = "Sagitario";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 12 && dia >= 22 || mes == 1 && dia <= 19)
                {
                    signo = "Capricornio";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 1 && dia >= 20 || mes == 2 && dia <= 18)
                {
                    signo = "Acuario";
                    tb_Signo.Text = signo.ToString();
                }
                else if (mes == 2 && dia >= 19 || mes == 3 && dia <= 20)
                {
                    signo = "Piscis";
                    tb_Signo.Text = signo.ToString();

                }
                else
                {
                    MessageBox.Show("NÚMERO DE MES INCORRECTO...!!!", "VENTANA DE MESES");

                }
            }
            else
            {
                MessageBox.Show("ESPACIOS VACIOS", "VENTANA DE VALIDACIÓN");
                tb_mesDia.Text = "";
                tb_dia.Text = "";
                tb_mesDia.Focus();
            }
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            Form2 ventana2 = new Form2();

            this.Hide();
            ventana2.Show();
        }
    }
}
