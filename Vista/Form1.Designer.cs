using PrimeraEntrega.DAOS;

namespace PrimeraEntrega
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
        // <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.TituloLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.MensajeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(23, 26);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(255, 16);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Credenciales  de sesión requeridas";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(26, 142);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.AcceptsTab = true;
            this.UsuarioTextBox.Location = new System.Drawing.Point(26, 77);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(252, 20);
            this.UsuarioTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AcceptsTab = true;
            this.PasswordTextBox.Location = new System.Drawing.Point(26, 116);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(252, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Location = new System.Drawing.Point(26, 58);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(96, 13);
            this.UsuarioLabel.TabIndex = 4;
            this.UsuarioLabel.Text = "Nombre de usuario";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(23, 100);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Contraseña";
            // 
            // MensajeLabel
            // 
            this.MensajeLabel.AutoSize = true;
            this.MensajeLabel.Location = new System.Drawing.Point(107, 147);
            this.MensajeLabel.Name = "MensajeLabel";
            this.MensajeLabel.Size = new System.Drawing.Size(0, 13);
            this.MensajeLabel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Registrate en nuestro sitio web!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 199);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MensajeLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TituloLabel);
            this.Name = "Form1";
            this.Text = "Progamita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label MensajeLabel;
        private UsuariosDAO DAO;
        private System.Windows.Forms.Label label1;
    }
}

