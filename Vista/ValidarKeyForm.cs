using PrimeraEntrega.DAOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimeraEntrega.data;

namespace PrimeraEntrega.Vista
{
    public partial class ValidarKeyForm : Form
    {
        
        public ValidarKeyForm(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Global.killApp();
        }
        private void regresarButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 kaka = new Form1();
            kaka.Show();
        }

        private void validarButton_Click(object sender, EventArgs e)
        {
            var flag = UsuariosDAO.getInstancia().validarKey(textBoxKey.Text,this.usuario);
            if (flag)
            {
                this.Hide();
                App app = new App(this.usuario);
                app.Show();
            }
            else {
                errorLabel.Text = "Key invalida";
            }
        }
    }
}
