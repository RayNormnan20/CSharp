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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            if (chbRojo.Checked == true)
            {
                this.BackColor = Color.Red;
            }
            if(chbAzul.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            if (chbVerde.Checked == true)
            {
                this.BackColor = Color.Green;
            }
            if(chbRojo.Checked == true && chbAzul.Checked == true)
            {
                this.BackColor = Color.Purple;
            }
            if (chbAzul.Checked == true && chbVerde.Checked == true)
            {
                this.BackColor = Color.Yellow;
            }


        }
    }
}
