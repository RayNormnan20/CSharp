using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacion_continua_01
{
    public partial class Form3 : Form
    {
        static double simple = 1500, medio = 2500, avanzado = 4500;
        public Form3()
        {
            InitializeComponent();
        }

        private void tb_sueldo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rb_empleado_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_empleado.Checked == true)
            {
                tb_sueldo.Text = simple.ToString();
            }
        }

        private void rb_administrador_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_administrador.Checked == true)
            {
                tb_sueldo.Text = medio.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String pension = cb_pension.Text;
            int sueldo = Convert.ToInt32(tb_sueldo.Text);
            double desc = 0;

            if (pension.Equals("AFP"))
            {
                desc = sueldo * 10 / 100;
                tb_descuento.Text = desc.ToString();
            }
            else if (pension.Equals("ONP"))
            {
                desc = sueldo * 13 / 100;
                tb_descuento.Text = desc.ToString();
            }
            else {
                MessageBox.Show("INGRESE UNA PENSION", "ERROR DE PENSION");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            String ver = tb_bonificacion.Text;

            if (!ver.Equals(""))
            {
                int sueldo = Convert.ToInt32(tb_sueldo.Text);
                int bonificacion = Convert.ToInt32(tb_bonificacion.Text);
                int descuento = Convert.ToInt32(tb_descuento.Text);
                int neto = 0;

                neto = (sueldo + bonificacion) - descuento;
                tb_neto.Text = neto.ToString();
            }
            else
            {
                MessageBox.Show("NO INGRESO UNO DE LOS PARAMETROS CORRECTAMENTE", "ERROR DE DATOS");
            }
            




        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void rb_gerente_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_gerente.Checked == true)
            {
                tb_sueldo.Text = avanzado.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String ec = cb_estadoCivil.Text;

            if (ec.Equals("SOLTERO") && ((rb_empleado.Checked == true) || (rb_administrador.Checked == true) || (rb_gerente.Checked == true)))
            {
                int suel = Convert.ToInt32(tb_sueldo.Text);
                double final = suel * 2 / 100;
                tb_bonificacion.Text = final.ToString();
            }
            else if (ec.Equals("CASADO") && ((rb_empleado.Checked == true) || (rb_administrador.Checked == true) || (rb_gerente.Checked == true)))
            {
                int suel = Convert.ToInt32(tb_sueldo.Text);
                double final = suel * 4 / 100;
                tb_bonificacion.Text = final.ToString();
            }
            else if (ec.Equals("DIVORCIADO") && ((rb_empleado.Checked == true) || (rb_administrador.Checked == true) || (rb_gerente.Checked == true)))
            {
                int suel = Convert.ToInt32(tb_sueldo.Text);
                double final = suel * 6 / 100;
                tb_bonificacion.Text = final.ToString();
            }
            else if (ec.Equals("VIUDO") && ((rb_empleado.Checked == true) || (rb_administrador.Checked == true) || (rb_gerente.Checked == true)))
            {
                int suel = Convert.ToInt32(tb_sueldo.Text);
                double final = suel * 8 / 100;
                tb_bonificacion.Text = final.ToString();
            }
            else {
                MessageBox.Show("INGRESE UN ESTADO CIVIL", "ERROR DE ESTADO");
            }

        }
    }
}
