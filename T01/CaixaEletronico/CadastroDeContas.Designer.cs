﻿namespace Benner.CaixaEletronico.CContas
{
    partial class CadastroDeContas
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
            this.titularConta = new System.Windows.Forms.TextBox();
            this.numeroConta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tipoDeConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titularConta
            // 
            this.titularConta.Location = new System.Drawing.Point(322, 124);
            this.titularConta.Name = "titularConta";
            this.titularConta.Size = new System.Drawing.Size(100, 20);
            this.titularConta.TabIndex = 0;
            // 
            // numeroConta
            // 
            this.numeroConta.Location = new System.Drawing.Point(322, 164);
            this.numeroConta.Name = "numeroConta";
            this.numeroConta.Size = new System.Drawing.Size(100, 20);
            this.numeroConta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cadastra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tipoDeConta
            // 
            this.tipoDeConta.Location = new System.Drawing.Point(322, 207);
            this.tipoDeConta.Name = "tipoDeConta";
            this.tipoDeConta.Size = new System.Drawing.Size(100, 20);
            this.tipoDeConta.TabIndex = 3;
            // 
            // CadastroDeContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tipoDeConta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeroConta);
            this.Controls.Add(this.titularConta);
            this.Name = "CadastroDeContas";
            this.Text = "CadastroDeContas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titularConta;
        private System.Windows.Forms.TextBox numeroConta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tipoDeConta;
    }
}