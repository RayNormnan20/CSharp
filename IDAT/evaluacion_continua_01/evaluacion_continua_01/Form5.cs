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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void chb_rojo_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_rojo.Checked)
            {
                this.BackColor = Color.Red;
            }
        }

        private void chb_verde_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_verde.Checked)
            {
                this.BackColor = Color.Green;
            }
        }

        private void chb_azul_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_azul.Checked)
            {
                this.BackColor = Color.Blue;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
