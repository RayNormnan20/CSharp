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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbx_Productos.Items.Clear();

            if (lb_productos.Text.Equals("MOUSE"))
            {
                lbx_Productos.Items.Add("Logitech Lightspeed G502 Hero");
                lbx_Productos.Items.Add("Logitech G Pro");
                lbx_Productos.Items.Add("Logitech G203");
            }
            else if (lb_productos.Text.Equals("TECLADO"))
            {
                lbx_Productos.Items.Add("Razer Cynosa V2 Chroma RGB");
                lbx_Productos.Items.Add("Logitech G513");
                lbx_Productos.Items.Add("HyperX Alloy Elite 2");
            }
            else if (lb_productos.Text.Equals("MONITOR"))
            {
                lbx_Productos.Items.Add("LG UltraGear 38GN950");
                lbx_Productos.Items.Add("Asus TUF Gaming VG289Q");
                lbx_Productos.Items.Add("Samsung Odyssey G7");
            }
        }

        

        private void lbx_Productos_SelectedIndexChanged(object sender, EventArgs e)
        {
            String producto = lb_productos.Text;

            if (producto.Equals("MOUSE"))
            {
                if (lbx_Productos.Text.Equals("Logitech Lightspeed G502 Hero"))
                {
                    int precio = 50;
                    tb_precio.Text = precio.ToString();
                }
                else if (lbx_Productos.Text.Equals("Logitech G Pro"))
                {
                    int precio = 150;
                    tb_precio.Text = precio.ToString();
                }
                else if (lbx_Productos.Text.Equals("Logitech G203"))
                {
                    int precio = 200;
                    tb_precio.Text = precio.ToString();
                }
            }
            else if (producto.Equals("TECLADO"))
            {
                if (lbx_Productos.Text.Equals("Razer Cynosa V2 Chroma RGB"))
                {
                    int precio = 25;
                    tb_precio.Text = precio.ToString();
                }
                else if (lbx_Productos.Text.Equals("Logitech G513"))
                {
                    int precio = 200;
                    tb_precio.Text = precio.ToString();
                }
                else if (lbx_Productos.Text.Equals("HyperX Alloy Elite 2"))
                {
                    int precio = 450;
                    tb_precio.Text = precio.ToString();
                }
            }
            else if (producto.Equals("MONITOR"))
            {
                if (lbx_Productos.Text.Equals("LG UltraGear 38GN950"))
                {
                    int precio = 250;
                    tb_precio.Text = precio.ToString();
                }
                else if (lbx_Productos.Text.Equals("Asus TUF Gaming VG289Q"))
                {
                    int precio = 400;
                    tb_precio.Text = precio.ToString();
                }
                else if (lbx_Productos.Text.Equals("Samsung Odyssey G7"))
                {
                    int precio = 800;
                    tb_precio.Text = precio.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String prec = tb_precio.Text;

            if (prec.Equals(""))
            {
                MessageBox.Show("ESCOGA UN PRODUCTO", "ERROR DE ITEMS");
            }
            else {
                int precio = Convert.ToInt32(tb_precio.Text);
                int cantidad = Convert.ToInt32(tb_cantidad.Text);
                int primertotal = 0;

                primertotal = precio * cantidad;
                tb_subtotal.Text = primertotal.ToString();

                double igv = 0;
                igv = primertotal * 18 / 100;
                tb_igv.Text = igv.ToString();

                double neto = 0;
                neto = primertotal + igv;
                tb_neto.Text = neto.ToString();
            }

            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
