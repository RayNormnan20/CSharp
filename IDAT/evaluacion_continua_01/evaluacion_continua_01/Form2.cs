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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pREGUNTA01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 vent3 = new Form3();
            this.Hide();
            vent3.Show();
        }

        private void pREGUNTA02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 vent4 = new Form4();
            this.Hide();
            vent4.Show();
        }

        private void pREGUNTA03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 vent5 = new Form5();
            this.Hide();
            vent5.Show();
        }

        private void pREGUNTA04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 vent6 = new Form6();
            this.Hide();
            vent6.Show();
        }

        private void eVALUACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
