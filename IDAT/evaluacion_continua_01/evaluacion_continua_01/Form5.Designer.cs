namespace evaluacion_continua_01
{
    partial class Form5
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
            this.gb_lista = new System.Windows.Forms.GroupBox();
            this.chb_azul = new System.Windows.Forms.CheckBox();
            this.chb_verde = new System.Windows.Forms.CheckBox();
            this.chb_rojo = new System.Windows.Forms.CheckBox();
            this.gb_lista.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PALETA DE COLORES";
            // 
            // gb_lista
            // 
            this.gb_lista.Controls.Add(this.chb_azul);
            this.gb_lista.Controls.Add(this.chb_verde);
            this.gb_lista.Controls.Add(this.chb_rojo);
            this.gb_lista.Location = new System.Drawing.Point(200, 69);
            this.gb_lista.Name = "gb_lista";
            this.gb_lista.Size = new System.Drawing.Size(200, 120);
            this.gb_lista.TabIndex = 1;
            this.gb_lista.TabStop = false;
            this.gb_lista.Text = "LISTA DE COLORES";
            this.gb_lista.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chb_azul
            // 
            this.chb_azul.AutoSize = true;
            this.chb_azul.Location = new System.Drawing.Point(6, 74);
            this.chb_azul.Name = "chb_azul";
            this.chb_azul.Size = new System.Drawing.Size(54, 17);
            this.chb_azul.TabIndex = 2;
            this.chb_azul.Text = "AZUL";
            this.chb_azul.UseVisualStyleBackColor = true;
            this.chb_azul.CheckedChanged += new System.EventHandler(this.chb_azul_CheckedChanged);
            // 
            // chb_verde
            // 
            this.chb_verde.AutoSize = true;
            this.chb_verde.Location = new System.Drawing.Point(6, 51);
            this.chb_verde.Name = "chb_verde";
            this.chb_verde.Size = new System.Drawing.Size(63, 17);
            this.chb_verde.TabIndex = 1;
            this.chb_verde.Text = "VERDE";
            this.chb_verde.UseVisualStyleBackColor = true;
            this.chb_verde.CheckedChanged += new System.EventHandler(this.chb_verde_CheckedChanged);
            // 
            // chb_rojo
            // 
            this.chb_rojo.AutoSize = true;
            this.chb_rojo.Location = new System.Drawing.Point(6, 28);
            this.chb_rojo.Name = "chb_rojo";
            this.chb_rojo.Size = new System.Drawing.Size(55, 17);
            this.chb_rojo.TabIndex = 0;
            this.chb_rojo.Text = "ROJO";
            this.chb_rojo.UseVisualStyleBackColor = true;
            this.chb_rojo.CheckedChanged += new System.EventHandler(this.chb_rojo_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 225);
            this.Controls.Add(this.gb_lista);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.gb_lista.ResumeLayout(false);
            this.gb_lista.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_lista;
        private System.Windows.Forms.CheckBox chb_azul;
        private System.Windows.Forms.CheckBox chb_verde;
        private System.Windows.Forms.CheckBox chb_rojo;
    }
}