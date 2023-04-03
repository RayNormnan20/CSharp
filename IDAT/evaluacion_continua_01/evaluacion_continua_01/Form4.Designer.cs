namespace evaluacion_continua_01
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_productos = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbx_Productos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cantidad = new System.Windows.Forms.TextBox();
            this.bt_calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_subtotal = new System.Windows.Forms.TextBox();
            this.tb_igv = new System.Windows.Forms.TextBox();
            this.tb_neto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_productos);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCTOS";
            // 
            // lb_productos
            // 
            this.lb_productos.FormattingEnabled = true;
            this.lb_productos.Items.AddRange(new object[] {
            "MOUSE",
            "TECLADO",
            "MONITOR"});
            this.lb_productos.Location = new System.Drawing.Point(6, 19);
            this.lb_productos.Name = "lb_productos";
            this.lb_productos.Size = new System.Drawing.Size(120, 95);
            this.lb_productos.TabIndex = 0;
            this.lb_productos.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbx_Productos);
            this.groupBox2.Location = new System.Drawing.Point(228, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLES DE PODUCTOS";
            // 
            // lbx_Productos
            // 
            this.lbx_Productos.FormattingEnabled = true;
            this.lbx_Productos.Location = new System.Drawing.Point(19, 19);
            this.lbx_Productos.Name = "lbx_Productos";
            this.lbx_Productos.Size = new System.Drawing.Size(195, 95);
            this.lbx_Productos.TabIndex = 0;
            this.lbx_Productos.SelectedIndexChanged += new System.EventHandler(this.lbx_Productos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRECIO DEL PRODUCTO";
            // 
            // tb_precio
            // 
            this.tb_precio.Enabled = false;
            this.tb_precio.Location = new System.Drawing.Point(263, 182);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(100, 20);
            this.tb_precio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "INGRESAR UNA CANTIDAD";
            // 
            // tb_cantidad
            // 
            this.tb_cantidad.Location = new System.Drawing.Point(263, 218);
            this.tb_cantidad.Name = "tb_cantidad";
            this.tb_cantidad.Size = new System.Drawing.Size(100, 20);
            this.tb_cantidad.TabIndex = 6;
            // 
            // bt_calcular
            // 
            this.bt_calcular.Location = new System.Drawing.Point(172, 255);
            this.bt_calcular.Name = "bt_calcular";
            this.bt_calcular.Size = new System.Drawing.Size(147, 23);
            this.bt_calcular.TabIndex = 7;
            this.bt_calcular.Text = "CALCULAR FACTURA";
            this.bt_calcular.UseVisualStyleBackColor = true;
            this.bt_calcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "SUBTOTAL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "IGV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "NETO";
            // 
            // tb_subtotal
            // 
            this.tb_subtotal.Location = new System.Drawing.Point(267, 298);
            this.tb_subtotal.Name = "tb_subtotal";
            this.tb_subtotal.Size = new System.Drawing.Size(100, 20);
            this.tb_subtotal.TabIndex = 11;
            // 
            // tb_igv
            // 
            this.tb_igv.Location = new System.Drawing.Point(267, 328);
            this.tb_igv.Name = "tb_igv";
            this.tb_igv.Size = new System.Drawing.Size(100, 20);
            this.tb_igv.TabIndex = 12;
            // 
            // tb_neto
            // 
            this.tb_neto.Location = new System.Drawing.Point(267, 355);
            this.tb_neto.Name = "tb_neto";
            this.tb_neto.Size = new System.Drawing.Size(100, 20);
            this.tb_neto.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 405);
            this.Controls.Add(this.tb_neto);
            this.Controls.Add(this.tb_igv);
            this.Controls.Add(this.tb_subtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_calcular);
            this.Controls.Add(this.tb_cantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lb_productos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbx_Productos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cantidad;
        private System.Windows.Forms.Button bt_calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_subtotal;
        private System.Windows.Forms.TextBox tb_igv;
        private System.Windows.Forms.TextBox tb_neto;
    }
}