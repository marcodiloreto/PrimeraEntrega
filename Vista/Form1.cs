using PrimeraEntrega.DAOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimeraEntrega.Vista;
using PrimeraEntrega.data;

namespace PrimeraEntrega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Global.setPrincipal(this);
            DAO = UsuariosDAO.getInstancia();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String nombre = UsuarioTextBox.Text;
            String pass = PasswordTextBox.Text;
            var flag = DAO.login(nombre, pass);
            MensajeLabel.Text = flag.ToString();
            if (flag){
                
                if (DAO.isPay(nombre))
                {
                    
                    App form3 = new App(nombre);
                    form3.Show();
                }
                else {
                    ValidarKeyForm caca = new ValidarKeyForm(nombre);
                    caca.Show();
                }  
                this.Hide();
            }
            else {
                MensajeLabel.Text = "Credenciales incorrectas";
            }


        }
    }
}
