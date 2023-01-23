namespace Basico_01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_1 = new System.Windows.Forms.TextBox();
            this.Tb_2 = new System.Windows.Forms.TextBox();
            this.Tb_3 = new System.Windows.Forms.TextBox();
            this.Bt_Multiplicar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_suma = new System.Windows.Forms.Button();
            this.bt_Restar = new System.Windows.Forms.Button();
            this.Bt_Dividir = new System.Windows.Forms.Button();
            this.Bt_Siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operaciones Básicas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(23, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Primer Valor:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(23, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(23, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(312, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 91);
            this.label5.TabIndex = 5;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 7;
            // 
            // Tb_1
            // 
            this.Tb_1.Location = new System.Drawing.Point(263, 129);
            this.Tb_1.Multiline = true;
            this.Tb_1.Name = "Tb_1";
            this.Tb_1.Size = new System.Drawing.Size(115, 34);
            this.Tb_1.TabIndex = 8;
            this.Tb_1.TextChanged += new System.EventHandler(this.Tb_1_TextChanged);
            // 
            // Tb_2
            // 
            this.Tb_2.Location = new System.Drawing.Point(263, 220);
            this.Tb_2.Multiline = true;
            this.Tb_2.Name = "Tb_2";
            this.Tb_2.Size = new System.Drawing.Size(120, 37);
            this.Tb_2.TabIndex = 9;
            this.Tb_2.TextChanged += new System.EventHandler(this.Tb_2_TextChanged);
            // 
            // Tb_3
            // 
            this.Tb_3.Enabled = false;
            this.Tb_3.Location = new System.Drawing.Point(263, 301);
            this.Tb_3.Multiline = true;
            this.Tb_3.Name = "Tb_3";
            this.Tb_3.Size = new System.Drawing.Size(120, 37);
            this.Tb_3.TabIndex = 10;
            // 
            // Bt_Multiplicar
            // 
            this.Bt_Multiplicar.BackColor = System.Drawing.Color.Yellow;
            this.Bt_Multiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Multiplicar.Location = new System.Drawing.Point(474, 185);
            this.Bt_Multiplicar.Name = "Bt_Multiplicar";
            this.Bt_Multiplicar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bt_Multiplicar.Size = new System.Drawing.Size(153, 54);
            this.Bt_Multiplicar.TabIndex = 12;
            this.Bt_Multiplicar.Text = "Multiplicar";
            this.Bt_Multiplicar.UseVisualStyleBackColor = false;
            this.Bt_Multiplicar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(474, 312);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(153, 57);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_suma
            // 
            this.bt_suma.BackColor = System.Drawing.Color.Yellow;
            this.bt_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_suma.Location = new System.Drawing.Point(474, 111);
            this.bt_suma.Name = "bt_suma";
            this.bt_suma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_suma.Size = new System.Drawing.Size(153, 52);
            this.bt_suma.TabIndex = 11;
            this.bt_suma.Text = "Sumar";
            this.bt_suma.UseVisualStyleBackColor = false;
            this.bt_suma.Click += new System.EventHandler(this.bt_suma_Click);
            // 
            // bt_Restar
            // 
            this.bt_Restar.BackColor = System.Drawing.Color.Yellow;
            this.bt_Restar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Restar.Location = new System.Drawing.Point(657, 112);
            this.bt_Restar.Name = "bt_Restar";
            this.bt_Restar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bt_Restar.Size = new System.Drawing.Size(153, 51);
            this.bt_Restar.TabIndex = 14;
            this.bt_Restar.Text = "Restar";
            this.bt_Restar.UseVisualStyleBackColor = false;
            this.bt_Restar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Bt_Dividir
            // 
            this.Bt_Dividir.BackColor = System.Drawing.Color.Yellow;
            this.Bt_Dividir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Dividir.Location = new System.Drawing.Point(657, 185);
            this.Bt_Dividir.Name = "Bt_Dividir";
            this.Bt_Dividir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bt_Dividir.Size = new System.Drawing.Size(153, 54);
            this.Bt_Dividir.TabIndex = 15;
            this.Bt_Dividir.Text = "Dividir";
            this.Bt_Dividir.UseVisualStyleBackColor = false;
            this.Bt_Dividir.Click += new System.EventHandler(this.Bt_Dividir_Click);
            // 
            // Bt_Siguiente
            // 
            this.Bt_Siguiente.BackColor = System.Drawing.Color.Crimson;
            this.Bt_Siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Siguiente.Location = new System.Drawing.Point(671, 312);
            this.Bt_Siguiente.Name = "Bt_Siguiente";
            this.Bt_Siguiente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Bt_Siguiente.Size = new System.Drawing.Size(153, 54);
            this.Bt_Siguiente.TabIndex = 16;
            this.Bt_Siguiente.Text = "Siguiente";
            this.Bt_Siguiente.UseVisualStyleBackColor = false;
            this.Bt_Siguiente.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(862, 416);
            this.Controls.Add(this.Bt_Siguiente);
            this.Controls.Add(this.Bt_Dividir);
            this.Controls.Add(this.bt_Restar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Bt_Multiplicar);
            this.Controls.Add(this.bt_suma);
            this.Controls.Add(this.Tb_3);
            this.Controls.Add(this.Tb_2);
            this.Controls.Add(this.Tb_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Operaciones Basicas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_1;
        private System.Windows.Forms.TextBox Tb_2;
        private System.Windows.Forms.TextBox Tb_3;
        private System.Windows.Forms.Button Bt_Multiplicar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_suma;
        private System.Windows.Forms.Button bt_Restar;
        private System.Windows.Forms.Button Bt_Dividir;
        private System.Windows.Forms.Button Bt_Siguiente;
    }
}

