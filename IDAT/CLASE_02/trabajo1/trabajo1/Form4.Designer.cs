namespace trabajo1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.txtCostHora = new System.Windows.Forms.TextBox();
            this.txtHorTra = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtAfp = new System.Windows.Forms.TextBox();
            this.txtNeto = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.btn_Siguiente = new System.Windows.Forms.Button();
            this.btn_Anterior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANILLA DE SUELDOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "INGRESAR EMPLEADO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "INGRESAR COSTO DE LA HORA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "INGRESAR HORAS TRABAJADAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 247);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "CALCULAR SUELDO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(266, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "CALCULAR DESCUENTO POR AFP 10%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 346);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "CALCULAR NETO";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(371, 84);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(132, 22);
            this.txtEmpleado.TabIndex = 7;
            // 
            // txtCostHora
            // 
            this.txtCostHora.Location = new System.Drawing.Point(371, 140);
            this.txtCostHora.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostHora.Name = "txtCostHora";
            this.txtCostHora.Size = new System.Drawing.Size(132, 22);
            this.txtCostHora.TabIndex = 8;
            // 
            // txtHorTra
            // 
            this.txtHorTra.Location = new System.Drawing.Point(371, 188);
            this.txtHorTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtHorTra.Name = "txtHorTra";
            this.txtHorTra.Size = new System.Drawing.Size(132, 22);
            this.txtHorTra.TabIndex = 9;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Enabled = false;
            this.txtSueldo.Location = new System.Drawing.Point(371, 239);
            this.txtSueldo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(132, 22);
            this.txtSueldo.TabIndex = 10;
            // 
            // txtAfp
            // 
            this.txtAfp.Enabled = false;
            this.txtAfp.Location = new System.Drawing.Point(371, 290);
            this.txtAfp.Margin = new System.Windows.Forms.Padding(4);
            this.txtAfp.Name = "txtAfp";
            this.txtAfp.Size = new System.Drawing.Size(132, 22);
            this.txtAfp.TabIndex = 11;
            // 
            // txtNeto
            // 
            this.txtNeto.Enabled = false;
            this.txtNeto.Location = new System.Drawing.Point(371, 346);
            this.txtNeto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNeto.Name = "txtNeto";
            this.txtNeto.Size = new System.Drawing.Size(132, 22);
            this.txtNeto.TabIndex = 12;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(585, 87);
            this.BtnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(100, 28);
            this.BtnCalcular.TabIndex = 13;
            this.BtnCalcular.Text = "CALCULAR";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(585, 153);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(100, 28);
            this.Btn_Limpiar.TabIndex = 14;
            this.Btn_Limpiar.Text = "LIMPIAR";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Siguiente
            // 
            this.btn_Siguiente.Location = new System.Drawing.Point(585, 222);
            this.btn_Siguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Siguiente.Name = "btn_Siguiente";
            this.btn_Siguiente.Size = new System.Drawing.Size(100, 28);
            this.btn_Siguiente.TabIndex = 15;
            this.btn_Siguiente.Text = "SIGUIENTE";
            this.btn_Siguiente.UseVisualStyleBackColor = true;
            this.btn_Siguiente.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Anterior
            // 
            this.btn_Anterior.Location = new System.Drawing.Point(585, 284);
            this.btn_Anterior.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Anterior.Name = "btn_Anterior";
            this.btn_Anterior.Size = new System.Drawing.Size(100, 28);
            this.btn_Anterior.TabIndex = 16;
            this.btn_Anterior.Text = "ANTERIOR";
            this.btn_Anterior.UseVisualStyleBackColor = true;
            this.btn_Anterior.Click += new System.EventHandler(this.btn_Anterior_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(737, 426);
            this.Controls.Add(this.btn_Anterior);
            this.Controls.Add(this.btn_Siguiente);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.txtNeto);
            this.Controls.Add(this.txtAfp);
            this.Controls.Add(this.txtSueldo);
            this.Controls.Add(this.txtHorTra);
            this.Controls.Add(this.txtCostHora);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PLANILLA DE SUELDOS";
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
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.TextBox txtCostHora;
        private System.Windows.Forms.TextBox txtHorTra;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtAfp;
        private System.Windows.Forms.TextBox txtNeto;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button btn_Siguiente;
        private System.Windows.Forms.Button btn_Anterior;
    }
}