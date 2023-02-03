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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(tbPrimerValor.Text);
            int n2 = Convert.ToInt32(tbSegundoValor.Text);
            int resultado = 0;

            string operacion = cboOperaciones.Text;

            if (operacion.Equals("SUMA"))
                resultado = n1 + n2;
            
            if (operacion.Equals("RESTA"))
                resultado = n1 - n2;
            if (operacion.Equals("MULTIPLICACION"))
                resultado = n1 * n2;
            if (operacion.Equals("DIVISION"))
                resultado = n1 / n2;

            tbResultado.Text = resultado.ToString();
        }

        private void cboOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
