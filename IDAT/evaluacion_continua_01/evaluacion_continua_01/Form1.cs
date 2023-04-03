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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {

            int intentos = Convert.ToInt32(lb_contador.Text);

            string usuario = "";
            string contraseña = "";

            if ((!cb_usuario.Equals("")) && (!tb_password.Equals("")))
            {
                usuario = cb_usuario.Text;
                contraseña = tb_password.Text;
            }
            else {
                MessageBox.Show("Ingrese datos","Venta de error");
            }

            if (usuario.Equals("USUARIO") && (contraseña.Equals("111")))
            {
                Form2 vent2 = new Form2();
                this.Hide();
                vent2.Show();
            }
            else if (usuario.Equals("EMPLEADO") && (contraseña.Equals("222")))
            {
                Form2 vent2 = new Form2();
                this.Hide();
                vent2.Show();
            }
            else if (usuario.Equals("GERENTE") && (contraseña.Equals("333")))
            {
                Form2 vent2 = new Form2();
                this.Hide();
                vent2.Show();
            }
            else {
                MessageBox.Show("Ingrese un usuario o contraseña correctamente", "Ventana Login");
                --intentos;
                this.BackColor = Color.Red;
              
            }

            lb_contador.Text = intentos.ToString();

            if (intentos == 0) {
                this.Close();
            }

            
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            cb_usuario.Text = "";
            tb_password.Text = "";
        }
    }
}
