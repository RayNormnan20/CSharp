using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLASE_03
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = 0;

            dni = Convert.ToInt32(tbDni.Text);

            //empleados
            int em1 = 76079786;
            int em2 = 76079787;
            int em3 = 76079788;
            int ad1 = 76079789;

            string usu = cboUsuario.Text;
            string rol = cboRoles.Text;

            if ((dni.Equals(em1)) && (usu.Equals("OBRERO") && (rol.Equals("USUARIO")))) {
                MessageBox.Show("SE LOGEO CORRECTAMENTE(OBRERO/USUARIO)", "VENTANA LOGEO");
                cboUsuario.Text = "";
                cboRoles.Text = "";
                tbDni.Text = "";
            }
            else if ((dni.Equals(em2)) && (usu.Equals("EMPLEADO") && (rol.Equals("USUARIO"))))
            {
                MessageBox.Show("SE LOGEO CORRECTAMENTE (EMPLEADO/USUARIO) ", "VENTANA LOGEO");
                cboUsuario.Text = "";
                cboRoles.Text = "";
                tbDni.Text = "";
            }
            else if ((dni.Equals(em3)) && (usu.Equals("GERENTE") && (rol.Equals("ADMINISTRADOR")))) {
                MessageBox.Show("SE LOGEO CORRECTAMENTE (GERENTE/ADMINISTRADOR) ", "VENTANA LOGEO");
                cboUsuario.Text = "";
                cboRoles.Text = "";
                tbDni.Text = "";
            }
            else if ((dni.Equals(ad1)) && (usu.Equals("ADMINISTRADOR") && (rol.Equals("ADMINISTRADOR"))))
            {
                MessageBox.Show("SE LOGEO CORRECTAMENTE (ADMINISTRADOR/ADMINISTRADOR) ", "VENTANA LOGEO");
                cboUsuario.Text = "";
                cboRoles.Text = "";
                tbDni.Text = "";
            }
            else {
                MessageBox.Show("NO SE PUDO LOGEAR", "VENTANA LOGEO");
                cboUsuario.Text = "";
                cboRoles.Text = "";
                tbDni.Text = "";
            }

        }





    

        private void cboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
