﻿
namespace ejerciciosgg.formas
{
    partial class salario
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSalarioActual = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNuevoSalario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Ingresa tu salario actual";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSalarioActual
            // 
            this.txtSalarioActual.Location = new System.Drawing.Point(53, 134);
            this.txtSalarioActual.Name = "txtSalarioActual";
            this.txtSalarioActual.Size = new System.Drawing.Size(161, 26);
            this.txtSalarioActual.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calcula tu nuevo salario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNuevoSalario
            // 
            this.lblNuevoSalario.AutoSize = true;
            this.lblNuevoSalario.Location = new System.Drawing.Point(49, 242);
            this.lblNuevoSalario.Name = "lblNuevoSalario";
            this.lblNuevoSalario.Size = new System.Drawing.Size(12, 20);
            this.lblNuevoSalario.TabIndex = 5;
            this.lblNuevoSalario.Text = "l";
            // 
            // salario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ejerciciosgg.Properties.Resources._50_Minimalist_Desktop_Wallpapers_and_Backgrounds__2022_Edition_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNuevoSalario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSalarioActual);
            this.Controls.Add(this.textBox1);
            this.Name = "salario";
            this.Text = "salario";
            this.Load += new System.EventHandler(this.salario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtSalarioActual;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNuevoSalario;
    }
}