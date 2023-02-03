using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo2
{
    public partial class frmCuatro : Form
    {
        public frmCuatro()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbProducto.Text = lbsProductos.Text;
            //También podemos usar:
            //txbProducto.Text = lsbProductos.SelectedItem.ToString();

            txbPrecio.Text = Convert.ToString(lbsProductos.SelectedIndex * 10);

        }

        private void lsbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupBox1.Text = "";
            txbPrecio.Text = "";
            lbsProductos.Items.Clear();

            if (lbsCategorias.Text.Equals("DISCOS DUROS"))
            {
                lbsProductos.Items.Add("DISCO DURO TOSHIBA 500GB P300 PARA PC");
                lbsProductos.Items.Add("DISCO DURO TOSHIBA 1TB P300 PARA PC");
                lbsProductos.Items.Add("DISCO DURO TOSHIBA 2TB P300 PARA PC");
                lbsProductos.Items.Add("DISCO DURO PARA LAPTOP 500GB TOSHIBA L200");
                lbsProductos.Items.Add("DISCO DURO PARA LAPTOP 1TB TOSHIBA L200");
                lbsProductos.Items.Add("DISCO DURO SATA 1TB WD PURPLE");
                lbsProductos.Items.Add("DISCO DURO SATA 2TB WD PURPLE");
                lbsProductos.Items.Add("DISCO DURO SATA 4TB WD PURPLE");
            }
            if (lbsCategorias.Text.Equals("DISCOS DUROS EXTERNOS"))
            {
                lbsProductos.Items.Add("DISCO EXTERNO CANVIO 1TB TOSHIBA USB 3.0.");
                lbsProductos.Items.Add("DISCO EXTERNO CANVIO 3TB TOSHIBA USB 3.0");
            }
            if (lbsCategorias.Text.Equals("IMPRESORAS"))
            {
                lbsProductos.Items.Add("EPSON");
            }
            

        }
    }
}
