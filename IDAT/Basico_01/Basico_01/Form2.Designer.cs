namespace Basico_01
{
    partial class Form2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tb_1 = new System.Windows.Forms.TextBox();
            this.Tb_4 = new System.Windows.Forms.TextBox();
            this.Tb_3 = new System.Windows.Forms.TextBox();
            this.Tb_2 = new System.Windows.Forms.TextBox();
            this.Tb_5 = new System.Windows.Forms.TextBox();
            this.Tb_6 = new System.Windows.Forms.TextBox();
            this.Bt_Calcular = new System.Windows.Forms.Button();
            this.Bt_Limpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Tb_7 = new System.Windows.Forms.TextBox();
            this.Bt_Anterior = new System.Windows.Forms.Button();
            this.Bt_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURACIÓN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresar producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresar Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "SubTotal";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "IGV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 455);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Neto";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Tb_1
            // 
            this.Tb_1.Location = new System.Drawing.Point(285, 89);
            this.Tb_1.Multiline = true;
            this.Tb_1.Name = "Tb_1";
            this.Tb_1.Size = new System.Drawing.Size(150, 37);
            this.Tb_1.TabIndex = 7;
            // 
            // Tb_4
            // 
            this.Tb_4.Enabled = false;
            this.Tb_4.Location = new System.Drawing.Point(285, 282);
            this.Tb_4.Multiline = true;
            this.Tb_4.Name = "Tb_4";
            this.Tb_4.Size = new System.Drawing.Size(150, 39);
            this.Tb_4.TabIndex = 8;
            this.Tb_4.TextChanged += new System.EventHandler(this.Tb_4_TextChanged);
            // 
            // Tb_3
            // 
            this.Tb_3.Location = new System.Drawing.Point(285, 218);
            this.Tb_3.Multiline = true;
            this.Tb_3.Name = "Tb_3";
            this.Tb_3.Size = new System.Drawing.Size(150, 36);
            this.Tb_3.TabIndex = 9;
            // 
            // Tb_2
            // 
            this.Tb_2.Location = new System.Drawing.Point(285, 154);
            this.Tb_2.Multiline = true;
            this.Tb_2.Name = "Tb_2";
            this.Tb_2.Size = new System.Drawing.Size(150, 36);
            this.Tb_2.TabIndex = 10;
            // 
            // Tb_5
            // 
            this.Tb_5.Enabled = false;
            this.Tb_5.Location = new System.Drawing.Point(285, 341);
            this.Tb_5.Multiline = true;
            this.Tb_5.Name = "Tb_5";
            this.Tb_5.Size = new System.Drawing.Size(150, 36);
            this.Tb_5.TabIndex = 11;
            this.Tb_5.TextChanged += new System.EventHandler(this.Tb_5_TextChanged);
            // 
            // Tb_6
            // 
            this.Tb_6.Enabled = false;
            this.Tb_6.Location = new System.Drawing.Point(285, 398);
            this.Tb_6.Multiline = true;
            this.Tb_6.Name = "Tb_6";
            this.Tb_6.Size = new System.Drawing.Size(150, 36);
            this.Tb_6.TabIndex = 12;
            // 
            // Bt_Calcular
            // 
            this.Bt_Calcular.BackColor = System.Drawing.Color.Lime;
            this.Bt_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Calcular.Location = new System.Drawing.Point(486, 429);
            this.Bt_Calcular.Name = "Bt_Calcular";
            this.Bt_Calcular.Size = new System.Drawing.Size(123, 55);
            this.Bt_Calcular.TabIndex = 13;
            this.Bt_Calcular.Text = "Calcular";
            this.Bt_Calcular.UseVisualStyleBackColor = false;
            this.Bt_Calcular.Click += new System.EventHandler(this.Bt_Calcular_Click);
            // 
            // Bt_Limpiar
            // 
            this.Bt_Limpiar.BackColor = System.Drawing.Color.Lime;
            this.Bt_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Limpiar.Location = new System.Drawing.Point(664, 436);
            this.Bt_Limpiar.Name = "Bt_Limpiar";
            this.Bt_Limpiar.Size = new System.Drawing.Size(123, 55);
            this.Bt_Limpiar.TabIndex = 14;
            this.Bt_Limpiar.Text = "Limpiar";
            this.Bt_Limpiar.UseVisualStyleBackColor = false;
            this.Bt_Limpiar.Click += new System.EventHandler(this.Bt_Limpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 29);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Tb_7
            // 
            this.Tb_7.Enabled = false;
            this.Tb_7.Location = new System.Drawing.Point(285, 455);
            this.Tb_7.Multiline = true;
            this.Tb_7.Name = "Tb_7";
            this.Tb_7.Size = new System.Drawing.Size(150, 36);
            this.Tb_7.TabIndex = 16;
            // 
            // Bt_Anterior
            // 
            this.Bt_Anterior.BackColor = System.Drawing.Color.Lime;
            this.Bt_Anterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Anterior.Location = new System.Drawing.Point(486, 119);
            this.Bt_Anterior.Name = "Bt_Anterior";
            this.Bt_Anterior.Size = new System.Drawing.Size(123, 55);
            this.Bt_Anterior.TabIndex = 17;
            this.Bt_Anterior.Text = "Anterior";
            this.Bt_Anterior.UseVisualStyleBackColor = false;
            this.Bt_Anterior.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bt_Salir
            // 
            this.Bt_Salir.BackColor = System.Drawing.Color.Red;
            this.Bt_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_Salir.Location = new System.Drawing.Point(664, 119);
            this.Bt_Salir.Name = "Bt_Salir";
            this.Bt_Salir.Size = new System.Drawing.Size(123, 55);
            this.Bt_Salir.TabIndex = 18;
            this.Bt_Salir.Text = "Salir";
            this.Bt_Salir.UseVisualStyleBackColor = false;
            this.Bt_Salir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(799, 526);
            this.Controls.Add(this.Bt_Salir);
            this.Controls.Add(this.Bt_Anterior);
            this.Controls.Add(this.Tb_7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Bt_Limpiar);
            this.Controls.Add(this.Bt_Calcular);
            this.Controls.Add(this.Tb_6);
            this.Controls.Add(this.Tb_5);
            this.Controls.Add(this.Tb_2);
            this.Controls.Add(this.Tb_3);
            this.Controls.Add(this.Tb_4);
            this.Controls.Add(this.Tb_1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Tb_1;
        private System.Windows.Forms.TextBox Tb_4;
        private System.Windows.Forms.TextBox Tb_3;
        private System.Windows.Forms.TextBox Tb_2;
        private System.Windows.Forms.TextBox Tb_5;
        private System.Windows.Forms.TextBox Tb_6;
        private System.Windows.Forms.Button Bt_Calcular;
        private System.Windows.Forms.Button Bt_Limpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tb_7;
        private System.Windows.Forms.Button Bt_Anterior;
        private System.Windows.Forms.Button Bt_Salir;
    }
}