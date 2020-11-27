
using System;

namespace PrimeraEntrega.Vista
{
    partial class ValidarKeyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                this.components.Dispose();
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
            this.validarButton = new System.Windows.Forms.Button();
            this.regresarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deberas ingresar la clave del producto para verificarte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "La clave tiene formato alfanumerico AAAA-BBBB-CCCC";
            // 
            // validarButton
            // 
            this.validarButton.Location = new System.Drawing.Point(211, 85);
            this.validarButton.Name = "validarButton";
            this.validarButton.Size = new System.Drawing.Size(75, 23);
            this.validarButton.TabIndex = 2;
            this.validarButton.Text = "Validar";
            this.validarButton.UseVisualStyleBackColor = true;
            this.validarButton.Click += new System.EventHandler(this.validarButton_Click);
            // 
            // regresarButton
            // 
            this.regresarButton.Location = new System.Drawing.Point(27, 85);
            this.regresarButton.Name = "regresarButton";
            this.regresarButton.Size = new System.Drawing.Size(75, 23);
            this.regresarButton.TabIndex = 3;
            this.regresarButton.Text = "regresar";
            this.regresarButton.UseVisualStyleBackColor = true;
            this.regresarButton.Click += new System.EventHandler(this.regresarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Una vez vinculada una clave con un usuario seran pareja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "de por vida =), NO HAY VUELTA ATRAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Asegúrese de estar logueado con el usuario correcto";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(27, 59);
            this.textBoxKey.MaxLength = 14;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(254, 20);
            this.textBoxKey.TabIndex = 7;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(108, 90);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 8;
            // 
            // ValidarKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 167);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regresarButton);
            this.Controls.Add(this.validarButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ValidarKeyForm";
            this.Text = "ValidarKeyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button validarButton;
        private System.Windows.Forms.Button regresarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxKey;
        private String usuario;
        private System.Windows.Forms.Label errorLabel;
    }
}