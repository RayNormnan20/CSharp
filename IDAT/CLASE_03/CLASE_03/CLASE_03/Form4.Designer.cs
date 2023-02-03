namespace Trabajo2
{
    partial class frmCuatro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lbsCategorias = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbsProductos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbProducto = new System.Windows.Forms.TextBox();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lbsCategorias);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 46);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(406, 322);
            this.GroupBox1.TabIndex = 0;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Categorías";
            // 
            // lbsCategorias
            // 
            this.lbsCategorias.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbsCategorias.FormattingEnabled = true;
            this.lbsCategorias.ItemHeight = 22;
            this.lbsCategorias.Items.AddRange(new object[] {
            "DISCOS DUROS",
            "DISCOS DUROS EXTERNOS",
            "FUENTE PODER",
            "IMPRESORAS",
            "MEMORIAS RAM",
            "MEMORIAS USB",
            "MONITORES",
            "PLACAS MADRE",
            "PROCESADORES",
            "TECLADOS"});
            this.lbsCategorias.Location = new System.Drawing.Point(17, 44);
            this.lbsCategorias.Name = "lbsCategorias";
            this.lbsCategorias.Size = new System.Drawing.Size(373, 268);
            this.lbsCategorias.Sorted = true;
            this.lbsCategorias.TabIndex = 0;
            this.lbsCategorias.SelectedIndexChanged += new System.EventHandler(this.lsbCategorias_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbsProductos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(478, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 322);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Productos";
            // 
            // lbsProductos
            // 
            this.lbsProductos.FormattingEnabled = true;
            this.lbsProductos.HorizontalScrollbar = true;
            this.lbsProductos.ItemHeight = 22;
            this.lbsProductos.Location = new System.Drawing.Point(15, 44);
            this.lbsProductos.Name = "lbsProductos";
            this.lbsProductos.Size = new System.Drawing.Size(428, 268);
            this.lbsProductos.TabIndex = 1;
            this.lbsProductos.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 389);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio:";
            // 
            // txbProducto
            // 
            this.txbProducto.Location = new System.Drawing.Point(321, 389);
            this.txbProducto.Name = "txbProducto";
            this.txbProducto.ReadOnly = true;
            this.txbProducto.Size = new System.Drawing.Size(350, 22);
            this.txbProducto.TabIndex = 4;
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(321, 441);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.ReadOnly = true;
            this.txbPrecio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txbPrecio.Size = new System.Drawing.Size(350, 22);
            this.txbPrecio.TabIndex = 5;
            // 
            // frmCuatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(973, 527);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.txbProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "frmCuatro";
            this.Text = "Cátalago";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.GroupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbProducto;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.ListBox lbsProductos;
        private System.Windows.Forms.ListBox lbsCategorias;
    }
}