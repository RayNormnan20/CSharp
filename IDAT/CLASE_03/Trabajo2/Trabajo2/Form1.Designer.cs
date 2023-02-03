namespace Trabajo2
{
    partial class frmUno
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
            this.cbIGV = new System.Windows.Forms.CheckBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbTerminos = new System.Windows.Forms.CheckBox();
            this.cbCorreos = new System.Windows.Forms.CheckBox();
            this.cbPagos = new System.Windows.Forms.CheckBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbIGV
            // 
            this.cbIGV.AutoSize = true;
            this.cbIGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIGV.Location = new System.Drawing.Point(12, 74);
            this.cbIGV.Name = "cbIGV";
            this.cbIGV.Size = new System.Drawing.Size(274, 29);
            this.cbIGV.TabIndex = 0;
            this.cbIGV.Text = "Los precios incluyen IGV";
            this.cbIGV.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(344, 35);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(108, 52);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbTerminos
            // 
            this.cbTerminos.AutoSize = true;
            this.cbTerminos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerminos.Location = new System.Drawing.Point(12, 141);
            this.cbTerminos.Name = "cbTerminos";
            this.cbTerminos.Size = new System.Drawing.Size(287, 24);
            this.cbTerminos.TabIndex = 2;
            this.cbTerminos.Text = "Acepto los términos y condiciones";
            this.cbTerminos.UseVisualStyleBackColor = true;
            this.cbTerminos.CheckedChanged += new System.EventHandler(this.cbTerminos_CheckedChanged);
            // 
            // cbCorreos
            // 
            this.cbCorreos.AutoSize = true;
            this.cbCorreos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCorreos.Location = new System.Drawing.Point(74, 195);
            this.cbCorreos.Name = "cbCorreos";
            this.cbCorreos.Size = new System.Drawing.Size(303, 24);
            this.cbCorreos.TabIndex = 3;
            this.cbCorreos.Text = "Acepto enviarme ofertas a mi correo";
            this.cbCorreos.UseVisualStyleBackColor = true;
            this.cbCorreos.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbPagos
            // 
            this.cbPagos.AutoSize = true;
            this.cbPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPagos.Location = new System.Drawing.Point(74, 240);
            this.cbPagos.Name = "cbPagos";
            this.cbPagos.Size = new System.Drawing.Size(437, 24);
            this.cbPagos.TabIndex = 4;
            this.cbPagos.Text = "Acepto descuentos mensulaes de mi tarjeta de crédito";
            this.cbPagos.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(372, 113);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(119, 52);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(515, 295);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.cbPagos);
            this.Controls.Add(this.cbCorreos);
            this.Controls.Add(this.cbTerminos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbIGV);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmUno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Uno";
            this.Load += new System.EventHandler(this.frmUno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbIGV;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.CheckBox cbTerminos;
        private System.Windows.Forms.CheckBox cbCorreos;
        private System.Windows.Forms.CheckBox cbPagos;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

