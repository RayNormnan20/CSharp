namespace evaluacion_continua_01
{
    partial class Form3
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
            this.rb_gerente = new System.Windows.Forms.RadioButton();
            this.rb_administrador = new System.Windows.Forms.RadioButton();
            this.rb_empleado = new System.Windows.Forms.RadioButton();
            this.tb_sueldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_bonificacion = new System.Windows.Forms.Button();
            this.tb_bonificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_estadoCivil = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_descuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_pension = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_neto = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PLANILLA DE SUELDO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_gerente);
            this.groupBox1.Controls.Add(this.rb_administrador);
            this.groupBox1.Controls.Add(this.rb_empleado);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 139);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CARGO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rb_gerente
            // 
            this.rb_gerente.AutoSize = true;
            this.rb_gerente.Location = new System.Drawing.Point(18, 104);
            this.rb_gerente.Name = "rb_gerente";
            this.rb_gerente.Size = new System.Drawing.Size(77, 17);
            this.rb_gerente.TabIndex = 2;
            this.rb_gerente.TabStop = true;
            this.rb_gerente.Text = "GERENTE";
            this.rb_gerente.UseVisualStyleBackColor = true;
            this.rb_gerente.CheckedChanged += new System.EventHandler(this.rb_gerente_CheckedChanged);
            // 
            // rb_administrador
            // 
            this.rb_administrador.AutoSize = true;
            this.rb_administrador.Location = new System.Drawing.Point(18, 71);
            this.rb_administrador.Name = "rb_administrador";
            this.rb_administrador.Size = new System.Drawing.Size(116, 17);
            this.rb_administrador.TabIndex = 1;
            this.rb_administrador.TabStop = true;
            this.rb_administrador.Text = "ADMINISTRADOR";
            this.rb_administrador.UseVisualStyleBackColor = true;
            this.rb_administrador.CheckedChanged += new System.EventHandler(this.rb_administrador_CheckedChanged);
            // 
            // rb_empleado
            // 
            this.rb_empleado.AutoSize = true;
            this.rb_empleado.Location = new System.Drawing.Point(18, 32);
            this.rb_empleado.Name = "rb_empleado";
            this.rb_empleado.Size = new System.Drawing.Size(84, 17);
            this.rb_empleado.TabIndex = 0;
            this.rb_empleado.TabStop = true;
            this.rb_empleado.Text = "EMPLEADO";
            this.rb_empleado.UseVisualStyleBackColor = true;
            this.rb_empleado.CheckedChanged += new System.EventHandler(this.rb_empleado_CheckedChanged);
            // 
            // tb_sueldo
            // 
            this.tb_sueldo.Enabled = false;
            this.tb_sueldo.Location = new System.Drawing.Point(160, 158);
            this.tb_sueldo.Name = "tb_sueldo";
            this.tb_sueldo.Size = new System.Drawing.Size(100, 20);
            this.tb_sueldo.TabIndex = 2;
            this.tb_sueldo.TextChanged += new System.EventHandler(this.tb_sueldo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "SUELDO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_bonificacion);
            this.groupBox2.Controls.Add(this.tb_bonificacion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cb_estadoCivil);
            this.groupBox2.Location = new System.Drawing.Point(300, 53);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 139);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ESTADO CIVIL";
            // 
            // bt_bonificacion
            // 
            this.bt_bonificacion.Location = new System.Drawing.Point(16, 110);
            this.bt_bonificacion.Name = "bt_bonificacion";
            this.bt_bonificacion.Size = new System.Drawing.Size(100, 23);
            this.bt_bonificacion.TabIndex = 3;
            this.bt_bonificacion.Text = "BONIFICACION";
            this.bt_bonificacion.UseVisualStyleBackColor = true;
            this.bt_bonificacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_bonificacion
            // 
            this.tb_bonificacion.Enabled = false;
            this.tb_bonificacion.Location = new System.Drawing.Point(16, 82);
            this.tb_bonificacion.Name = "tb_bonificacion";
            this.tb_bonificacion.Size = new System.Drawing.Size(100, 20);
            this.tb_bonificacion.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "BONIFICACION";
            // 
            // cb_estadoCivil
            // 
            this.cb_estadoCivil.FormattingEnabled = true;
            this.cb_estadoCivil.Items.AddRange(new object[] {
            "SOLTERO",
            "CASADO",
            "DIVORCIADO",
            "VIUDO"});
            this.cb_estadoCivil.Location = new System.Drawing.Point(16, 19);
            this.cb_estadoCivil.Name = "cb_estadoCivil";
            this.cb_estadoCivil.Size = new System.Drawing.Size(121, 21);
            this.cb_estadoCivil.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.tb_descuento);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cb_pension);
            this.groupBox3.Location = new System.Drawing.Point(12, 196);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(187, 130);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PENSION";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 101);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "DESCUENTO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_descuento
            // 
            this.tb_descuento.Enabled = false;
            this.tb_descuento.Location = new System.Drawing.Point(6, 71);
            this.tb_descuento.Name = "tb_descuento";
            this.tb_descuento.Size = new System.Drawing.Size(100, 20);
            this.tb_descuento.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "DESCUENTO";
            // 
            // cb_pension
            // 
            this.cb_pension.FormattingEnabled = true;
            this.cb_pension.Items.AddRange(new object[] {
            "ONP",
            "AFP"});
            this.cb_pension.Location = new System.Drawing.Point(6, 19);
            this.cb_pension.Name = "cb_pension";
            this.cb_pension.Size = new System.Drawing.Size(121, 21);
            this.cb_pension.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(313, 241);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "CALCULAR EL NETO";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tb_neto
            // 
            this.tb_neto.Enabled = false;
            this.tb_neto.Location = new System.Drawing.Point(313, 280);
            this.tb_neto.Name = "tb_neto";
            this.tb_neto.Size = new System.Drawing.Size(100, 20);
            this.tb_neto.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 338);
            this.Controls.Add(this.tb_neto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_sueldo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_gerente;
        private System.Windows.Forms.RadioButton rb_administrador;
        private System.Windows.Forms.RadioButton rb_empleado;
        private System.Windows.Forms.TextBox tb_sueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_bonificacion;
        private System.Windows.Forms.TextBox tb_bonificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_estadoCivil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_descuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_pension;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_neto;
    }
}