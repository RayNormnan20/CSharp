﻿namespace CLASE_03
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboOperaciones = new System.Windows.Forms.ComboBox();
            this.tbPrimerValor = new System.Windows.Forms.TextBox();
            this.tbSegundoValor = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "OPERACIONES BÁSICAS ";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(587, 241);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(136, 46);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRIMER VALOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "SEGUNDO VALOR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "OPERACION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "RESULTADOS";
            // 
            // cboOperaciones
            // 
            this.cboOperaciones.FormattingEnabled = true;
            this.cboOperaciones.Items.AddRange(new object[] {
            "SUMA",
            "RESTA",
            "MULTIPLICACION",
            "DIVISION"});
            this.cboOperaciones.Location = new System.Drawing.Point(316, 260);
            this.cboOperaciones.Name = "cboOperaciones";
            this.cboOperaciones.Size = new System.Drawing.Size(153, 24);
            this.cboOperaciones.TabIndex = 9;
            this.cboOperaciones.SelectedIndexChanged += new System.EventHandler(this.cboOperaciones_SelectedIndexChanged);
            // 
            // tbPrimerValor
            // 
            this.tbPrimerValor.Location = new System.Drawing.Point(316, 122);
            this.tbPrimerValor.Name = "tbPrimerValor";
            this.tbPrimerValor.Size = new System.Drawing.Size(153, 22);
            this.tbPrimerValor.TabIndex = 10;
            // 
            // tbSegundoValor
            // 
            this.tbSegundoValor.Location = new System.Drawing.Point(316, 189);
            this.tbSegundoValor.Name = "tbSegundoValor";
            this.tbSegundoValor.Size = new System.Drawing.Size(153, 22);
            this.tbSegundoValor.TabIndex = 11;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(316, 327);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(153, 22);
            this.tbResultado.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbSegundoValor);
            this.Controls.Add(this.tbPrimerValor);
            this.Controls.Add(this.cboOperaciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "OPERACIONES BÁSICAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboOperaciones;
        private System.Windows.Forms.TextBox tbPrimerValor;
        private System.Windows.Forms.TextBox tbSegundoValor;
        private System.Windows.Forms.TextBox tbResultado;
    }
}