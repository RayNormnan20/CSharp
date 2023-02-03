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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if(rbN1.Checked == true)
            {
                Width = 640;
                Height = 480;
            }
            if (rbN2.Checked == true)
            {
                Width = 800;
                Height = 600;
            }
            if (rbN3.Checked == true)
            {
                Width = 1024;
                Height = 768;
            }

        }
    }
}
