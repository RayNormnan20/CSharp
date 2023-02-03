namespace CLASE_03
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
            this.chbRojo = new System.Windows.Forms.CheckBox();
            this.chbAzul = new System.Windows.Forms.CheckBox();
            this.chbVerde = new System.Windows.Forms.CheckBox();
            this.btnPintar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chbRojo
            // 
            this.chbRojo.AutoSize = true;
            this.chbRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbRojo.Location = new System.Drawing.Point(119, 97);
            this.chbRojo.Name = "chbRojo";
            this.chbRojo.Size = new System.Drawing.Size(69, 24);
            this.chbRojo.TabIndex = 0;
            this.chbRojo.Text = "Rojo";
            this.chbRojo.UseVisualStyleBackColor = true;
            // 
            // chbAzul
            // 
            this.chbAzul.AutoSize = true;
            this.chbAzul.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAzul.Location = new System.Drawing.Point(119, 170);
            this.chbAzul.Name = "chbAzul";
            this.chbAzul.Size = new System.Drawing.Size(68, 24);
            this.chbAzul.TabIndex = 1;
            this.chbAzul.Text = "Azul";
            this.chbAzul.UseVisualStyleBackColor = true;
            // 
            // chbVerde
            // 
            this.chbVerde.AutoSize = true;
            this.chbVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbVerde.Location = new System.Drawing.Point(119, 251);
            this.chbVerde.Name = "chbVerde";
            this.chbVerde.Size = new System.Drawing.Size(80, 24);
            this.chbVerde.TabIndex = 2;
            this.chbVerde.Text = "Verde";
            this.chbVerde.UseVisualStyleBackColor = true;
            // 
            // btnPintar
            // 
            this.btnPintar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPintar.Location = new System.Drawing.Point(475, 97);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(101, 47);
            this.btnPintar.TabIndex = 3;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(506, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "PALETA DE COLORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 314);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPintar);
            this.Controls.Add(this.chbVerde);
            this.Controls.Add(this.chbAzul);
            this.Controls.Add(this.chbRojo);
            this.Name = "Form1";
            this.Text = "PALETA DE COLORES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbRojo;
        private System.Windows.Forms.CheckBox chbAzul;
        private System.Windows.Forms.CheckBox chbVerde;
        private System.Windows.Forms.Button btnPintar;
        private System.Windows.Forms.Label label1;
    }
}

