using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimeraEntrega.ffmpeg;
using PrimeraEntrega.data;

namespace PrimeraEntrega.Vista
{
    public partial class App : Form
    {
        private String usuario;
        private String ruta;
        private String archivo;

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Global.killApp();
        }
        /*
         Los GroupBox (en grafico) son un asco por que si los haces igual, el IDE te los
         mete uno adentro del otro, al querer superponerlos (para que esten en el mismo lugar)
         */
        public App(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            cambiarFormatoBox.Visible = false;
            quitarAudioGroup.Visible = false;
            resolucionGroup.Visible = false;
            extraerImagenesGroup.Visible = false;
            extraerAudioGroup.Visible = false;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (archivoDialog.ShowDialog() == DialogResult.OK)
            {
                ruta = archivoDialog.FileName;
                archivo = archivoDialog.SafeFileName;
                labelArchivo.Text = archivo;
                cerrarArchivoButton.Visible = true;
                axWindowsMediaPlayer1.URL = ruta;
            }
            else
            {
                if (archivo == null)
                {
                    labelArchivo.Text = "Ningún archivo seleccionado";
                }
            }
        }

        private void cerrarArchivoButton_Click(object sender, EventArgs e)
        {
            ruta = null;
            archivo = null;
            labelArchivo.Text = "Ningún archivo seleccionado";
            cerrarArchivoButton.Visible = false;
            axWindowsMediaPlayer1.URL = null;
        }

        private void FormatoButton_Click(object sender, EventArgs e)
        {
            cambiarFormatoBox.Visible = true;
            quitarAudioGroup.Visible = false;
            resolucionGroup.Visible = false;
            extraerImagenesGroup.Visible = false;
            extraerAudioGroup.Visible = false;
        }

        private void ResolucionButton_Click(object sender, EventArgs e)
        {
            cambiarFormatoBox.Visible = false;
            quitarAudioGroup.Visible = false;
            resolucionGroup.Visible = true;
            extraerImagenesGroup.Visible = false;
            extraerAudioGroup.Visible = false;
        }

        private void ExtraerAudioButton_Click(object sender, EventArgs e)
        {
            cambiarFormatoBox.Visible = false;
            quitarAudioGroup.Visible = false;
            resolucionGroup.Visible = false;
            extraerImagenesGroup.Visible = false;
            extraerAudioGroup.Visible = true;
        }

        private void QuitarAudioButton_Click(object sender, EventArgs e)
        {
            cambiarFormatoBox.Visible = false;
            quitarAudioGroup.Visible = true;
            resolucionGroup.Visible = false;
            extraerImagenesGroup.Visible = false;
            extraerAudioGroup.Visible = false;
        }

        private void ExtraerImagenesButton_Click(object sender, EventArgs e) 
        {
            cambiarFormatoBox.Visible = false;
            quitarAudioGroup.Visible = false;
            resolucionGroup.Visible = false;
            extraerImagenesGroup.Visible = true;
            extraerAudioGroup.Visible = false;
        }

        private void extraerAudioExportar_Click(object sender, EventArgs e)
        {
            Ffmpeg.extraerAudio(ruta, archivo);
        }

        private void QuitarAudioExportar_Click(object sender, EventArgs e)
        {
            Ffmpeg.quitarAudio(ruta, archivo);
        }

        private void extraerImagenesExportar_Click(object sender, EventArgs e)
        {
            Ffmpeg.extraerImagenes(ruta, archivo, textBoxExtraerImagenes.Text);
        }

        private void cambiarFormatoExportar_Click(object sender, EventArgs e)
        {
            String formato = cambiarFormatoBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

            Ffmpeg.cambiarFormato(ruta,archivo,formato);
        }

        private void resolucionExportar_Click(object sender, EventArgs e)
        {
            Ffmpeg.cambiarResolucion(ruta, archivo, TextBoxResolucionX.Text, TextBoxResolucionY.Text);

        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.usuario = null;
            Form1 form = new Form1();
            form.Show();
            this.Dispose();
        }
    }
}
