namespace CLASE_03
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
            this.rbN1 = new System.Windows.Forms.RadioButton();
            this.rbN2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbN3 = new System.Windows.Forms.RadioButton();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbN1
            // 
            this.rbN1.AutoSize = true;
            this.rbN1.Location = new System.Drawing.Point(30, 44);
            this.rbN1.Name = "rbN1";
            this.rbN1.Size = new System.Drawing.Size(90, 21);
            this.rbN1.TabIndex = 0;
            this.rbN1.TabStop = true;
            this.rbN1.Text = "660 * 480";
            this.rbN1.UseVisualStyleBackColor = true;
            // 
            // rbN2
            // 
            this.rbN2.AutoSize = true;
            this.rbN2.Location = new System.Drawing.Point(30, 100);
            this.rbN2.Name = "rbN2";
            this.rbN2.Size = new System.Drawing.Size(90, 21);
            this.rbN2.TabIndex = 1;
            this.rbN2.TabStop = true;
            this.rbN2.Text = "800 * 600";
            this.rbN2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "TAMAÑO DE VENTANA ";
            // 
            // rbN3
            // 
            this.rbN3.AutoSize = true;
            this.rbN3.Location = new System.Drawing.Point(30, 157);
            this.rbN3.Name = "rbN3";
            this.rbN3.Size = new System.Drawing.Size(98, 21);
            this.rbN3.TabIndex = 3;
            this.rbN3.TabStop = true;
            this.rbN3.Text = "1024 * 768";
            this.rbN3.UseVisualStyleBackColor = true;
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(498, 142);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(105, 44);
            this.btnCambiar.TabIndex = 4;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbN1);
            this.groupBox1.Controls.Add(this.rbN2);
            this.groupBox1.Controls.Add(this.rbN3);
            this.groupBox1.Location = new System.Drawing.Point(31, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TAMAÑO";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 391);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TAMAÑO DE VENTANA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbN1;
        private System.Windows.Forms.RadioButton rbN2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbN3;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}