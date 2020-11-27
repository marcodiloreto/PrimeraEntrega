using System.Windows.Forms;

namespace PrimeraEntrega.Vista
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormatoButton = new System.Windows.Forms.Button();
            this.ExtraerAudioButton = new System.Windows.Forms.Button();
            this.QuitarAudioButton = new System.Windows.Forms.Button();
            this.ResolucionButton = new System.Windows.Forms.Button();
            this.ExtraerImagenesButton = new System.Windows.Forms.Button();
            this.resolucionGroup = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TextBoxResolucionY = new System.Windows.Forms.TextBox();
            this.TextBoxResolucionX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.resolucionExportar = new System.Windows.Forms.Button();
            this.archivoDialog = new System.Windows.Forms.OpenFileDialog();
            this.labelArchivo = new System.Windows.Forms.Label();
            this.cerrarArchivoButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.quitarAudioGroup = new System.Windows.Forms.GroupBox();
            this.QuitarAudioExportar = new System.Windows.Forms.Button();
            this.mp4Button = new System.Windows.Forms.RadioButton();
            this.aviButton = new System.Windows.Forms.RadioButton();
            this.mpegButton = new System.Windows.Forms.RadioButton();
            this.movButton = new System.Windows.Forms.RadioButton();
            this.flvButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cambiarFormatoBox = new System.Windows.Forms.GroupBox();
            this.cambiarFormatoExportar = new System.Windows.Forms.Button();
            this.extraerImagenesGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxExtraerImagenes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.extraerImagenesExportar = new System.Windows.Forms.Button();
            this.extraerAudioGroup = new System.Windows.Forms.GroupBox();
            this.extraerAudioExportar = new System.Windows.Forms.Button();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.resolucionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.quitarAudioGroup.SuspendLayout();
            this.cambiarFormatoBox.SuspendLayout();
            this.extraerImagenesGroup.SuspendLayout();
            this.extraerAudioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.nuevoToolStripMenuItem.Text = "Abrir archivo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            // 
            // FormatoButton
            // 
            this.FormatoButton.Location = new System.Drawing.Point(710, 267);
            this.FormatoButton.Name = "FormatoButton";
            this.FormatoButton.Size = new System.Drawing.Size(131, 74);
            this.FormatoButton.TabIndex = 1;
            this.FormatoButton.Text = "Cambiar formato";
            this.FormatoButton.UseVisualStyleBackColor = true;
            this.FormatoButton.Click += new System.EventHandler(this.FormatoButton_Click);
            // 
            // ExtraerAudioButton
            // 
            this.ExtraerAudioButton.Location = new System.Drawing.Point(710, 110);
            this.ExtraerAudioButton.Name = "ExtraerAudioButton";
            this.ExtraerAudioButton.Size = new System.Drawing.Size(131, 73);
            this.ExtraerAudioButton.TabIndex = 2;
            this.ExtraerAudioButton.Text = "Extraer audio";
            this.ExtraerAudioButton.UseVisualStyleBackColor = true;
            this.ExtraerAudioButton.Click += new System.EventHandler(this.ExtraerAudioButton_Click);
            // 
            // QuitarAudioButton
            // 
            this.QuitarAudioButton.Location = new System.Drawing.Point(710, 189);
            this.QuitarAudioButton.Name = "QuitarAudioButton";
            this.QuitarAudioButton.Size = new System.Drawing.Size(131, 73);
            this.QuitarAudioButton.TabIndex = 3;
            this.QuitarAudioButton.Text = "Quitar audio";
            this.QuitarAudioButton.UseVisualStyleBackColor = true;
            this.QuitarAudioButton.Click += new System.EventHandler(this.QuitarAudioButton_Click);
            // 
            // ResolucionButton
            // 
            this.ResolucionButton.Location = new System.Drawing.Point(710, 31);
            this.ResolucionButton.Name = "ResolucionButton";
            this.ResolucionButton.Size = new System.Drawing.Size(131, 73);
            this.ResolucionButton.TabIndex = 4;
            this.ResolucionButton.Text = "Resolucion";
            this.ResolucionButton.UseVisualStyleBackColor = true;
            this.ResolucionButton.Click += new System.EventHandler(this.ResolucionButton_Click);
            // 
            // ExtraerImagenesButton
            // 
            this.ExtraerImagenesButton.Location = new System.Drawing.Point(710, 347);
            this.ExtraerImagenesButton.Name = "ExtraerImagenesButton";
            this.ExtraerImagenesButton.Size = new System.Drawing.Size(131, 73);
            this.ExtraerImagenesButton.TabIndex = 5;
            this.ExtraerImagenesButton.Text = "Extraer imagenes";
            this.ExtraerImagenesButton.UseVisualStyleBackColor = true;
            this.ExtraerImagenesButton.Click += new System.EventHandler(this.ExtraerImagenesButton_Click);
            // 
            // resolucionGroup
            // 
            this.resolucionGroup.Controls.Add(this.label7);
            this.resolucionGroup.Controls.Add(this.label8);
            this.resolucionGroup.Controls.Add(this.TextBoxResolucionY);
            this.resolucionGroup.Controls.Add(this.TextBoxResolucionX);
            this.resolucionGroup.Controls.Add(this.label6);
            this.resolucionGroup.Controls.Add(this.label5);
            this.resolucionGroup.Controls.Add(this.resolucionExportar);
            this.resolucionGroup.Location = new System.Drawing.Point(12, 27);
            this.resolucionGroup.Name = "resolucionGroup";
            this.resolucionGroup.Size = new System.Drawing.Size(164, 397);
            this.resolucionGroup.TabIndex = 6;
            this.resolucionGroup.TabStop = false;
            this.resolucionGroup.Text = "Cambiar resolucion del video";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "x";
            // 
            // TextBoxResolucionY
            // 
            this.TextBoxResolucionY.Location = new System.Drawing.Point(40, 321);
            this.TextBoxResolucionY.Name = "TextBoxResolucionY";
            this.TextBoxResolucionY.Size = new System.Drawing.Size(48, 20);
            this.TextBoxResolucionY.TabIndex = 4;
            // 
            // TextBoxResolucionX
            // 
            this.TextBoxResolucionX.Location = new System.Drawing.Point(40, 282);
            this.TextBoxResolucionX.Name = "TextBoxResolucionX";
            this.TextBoxResolucionX.Size = new System.Drawing.Size(48, 20);
            this.TextBoxResolucionX.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cambiar resolucion a:";
            // 
            // resolucionExportar
            // 
            this.resolucionExportar.Location = new System.Drawing.Point(83, 368);
            this.resolucionExportar.Name = "resolucionExportar";
            this.resolucionExportar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resolucionExportar.Size = new System.Drawing.Size(75, 23);
            this.resolucionExportar.TabIndex = 1;
            this.resolucionExportar.Text = "Exportar";
            this.resolucionExportar.UseVisualStyleBackColor = true;
            this.resolucionExportar.Click += new System.EventHandler(this.resolucionExportar_Click);
            // 
            // archivoDialog
            // 
            this.archivoDialog.FileName = "archivoDialog";
            // 
            // labelArchivo
            // 
            this.labelArchivo.AutoSize = true;
            this.labelArchivo.Location = new System.Drawing.Point(625, 6);
            this.labelArchivo.Name = "labelArchivo";
            this.labelArchivo.Size = new System.Drawing.Size(145, 13);
            this.labelArchivo.TabIndex = 7;
            this.labelArchivo.Text = "Ningún archivo seleccionado";
            // 
            // cerrarArchivoButton
            // 
            this.cerrarArchivoButton.Image = ((System.Drawing.Image)(resources.GetObject("cerrarArchivoButton.Image")));
            this.cerrarArchivoButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cerrarArchivoButton.Location = new System.Drawing.Point(597, -1);
            this.cerrarArchivoButton.Name = "cerrarArchivoButton";
            this.cerrarArchivoButton.Size = new System.Drawing.Size(29, 30);
            this.cerrarArchivoButton.TabIndex = 8;
            this.cerrarArchivoButton.UseVisualStyleBackColor = true;
            this.cerrarArchivoButton.Visible = false;
            this.cerrarArchivoButton.Click += new System.EventHandler(this.cerrarArchivoButton_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 448);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(692, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(182, 35);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(522, 393);
            this.axWindowsMediaPlayer1.TabIndex = 9;
            // 
            // quitarAudioGroup
            // 
            this.quitarAudioGroup.Controls.Add(this.QuitarAudioExportar);
            this.quitarAudioGroup.Location = new System.Drawing.Point(4, 18);
            this.quitarAudioGroup.Name = "quitarAudioGroup";
            this.quitarAudioGroup.Size = new System.Drawing.Size(179, 402);
            this.quitarAudioGroup.TabIndex = 7;
            this.quitarAudioGroup.TabStop = false;
            this.quitarAudioGroup.Text = "Quitar Audio";
            // 
            // QuitarAudioExportar
            // 
            this.QuitarAudioExportar.Location = new System.Drawing.Point(83, 366);
            this.QuitarAudioExportar.Name = "QuitarAudioExportar";
            this.QuitarAudioExportar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuitarAudioExportar.Size = new System.Drawing.Size(75, 23);
            this.QuitarAudioExportar.TabIndex = 0;
            this.QuitarAudioExportar.Text = "Exportar";
            this.QuitarAudioExportar.UseVisualStyleBackColor = true;
            this.QuitarAudioExportar.Click += new System.EventHandler(this.QuitarAudioExportar_Click);
            // 
            // mp4Button
            // 
            this.mp4Button.AutoSize = true;
            this.mp4Button.Location = new System.Drawing.Point(9, 181);
            this.mp4Button.Name = "mp4Button";
            this.mp4Button.Size = new System.Drawing.Size(50, 17);
            this.mp4Button.TabIndex = 1;
            this.mp4Button.TabStop = true;
            this.mp4Button.Text = ".MP4";
            this.mp4Button.UseVisualStyleBackColor = true;
            // 
            // aviButton
            // 
            this.aviButton.AutoSize = true;
            this.aviButton.Location = new System.Drawing.Point(9, 205);
            this.aviButton.Name = "aviButton";
            this.aviButton.Size = new System.Drawing.Size(45, 17);
            this.aviButton.TabIndex = 2;
            this.aviButton.TabStop = true;
            this.aviButton.Text = ".AVI";
            this.aviButton.UseVisualStyleBackColor = true;
            // 
            // mpegButton
            // 
            this.mpegButton.AutoSize = true;
            this.mpegButton.Location = new System.Drawing.Point(9, 229);
            this.mpegButton.Name = "mpegButton";
            this.mpegButton.Size = new System.Drawing.Size(59, 17);
            this.mpegButton.TabIndex = 3;
            this.mpegButton.TabStop = true;
            this.mpegButton.Text = ".MPEG";
            this.mpegButton.UseVisualStyleBackColor = true;
            // 
            // movButton
            // 
            this.movButton.AutoSize = true;
            this.movButton.Location = new System.Drawing.Point(9, 252);
            this.movButton.Name = "movButton";
            this.movButton.Size = new System.Drawing.Size(52, 17);
            this.movButton.TabIndex = 4;
            this.movButton.TabStop = true;
            this.movButton.Text = ".MOV";
            this.movButton.UseVisualStyleBackColor = true;
            // 
            // flvButton
            // 
            this.flvButton.AutoSize = true;
            this.flvButton.Location = new System.Drawing.Point(9, 158);
            this.flvButton.Name = "flvButton";
            this.flvButton.Size = new System.Drawing.Size(47, 17);
            this.flvButton.TabIndex = 5;
            this.flvButton.TabStop = true;
            this.flvButton.Text = ".FLV";
            this.flvButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Elija el formato final de su video";
            // 
            // cambiarFormatoBox
            // 
            this.cambiarFormatoBox.Controls.Add(this.cambiarFormatoExportar);
            this.cambiarFormatoBox.Controls.Add(this.label1);
            this.cambiarFormatoBox.Controls.Add(this.flvButton);
            this.cambiarFormatoBox.Controls.Add(this.mp4Button);
            this.cambiarFormatoBox.Controls.Add(this.movButton);
            this.cambiarFormatoBox.Controls.Add(this.aviButton);
            this.cambiarFormatoBox.Controls.Add(this.mpegButton);
            this.cambiarFormatoBox.Location = new System.Drawing.Point(4, 20);
            this.cambiarFormatoBox.Name = "cambiarFormatoBox";
            this.cambiarFormatoBox.Size = new System.Drawing.Size(176, 404);
            this.cambiarFormatoBox.TabIndex = 10;
            this.cambiarFormatoBox.TabStop = false;
            this.cambiarFormatoBox.Text = "Cambiar formato del video";
            this.cambiarFormatoBox.Visible = false;
            // 
            // cambiarFormatoExportar
            // 
            this.cambiarFormatoExportar.Location = new System.Drawing.Point(90, 370);
            this.cambiarFormatoExportar.Name = "cambiarFormatoExportar";
            this.cambiarFormatoExportar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cambiarFormatoExportar.Size = new System.Drawing.Size(75, 23);
            this.cambiarFormatoExportar.TabIndex = 1;
            this.cambiarFormatoExportar.Text = "Exportar";
            this.cambiarFormatoExportar.UseVisualStyleBackColor = true;
            this.cambiarFormatoExportar.Click += new System.EventHandler(this.cambiarFormatoExportar_Click);
            // 
            // extraerImagenesGroup
            // 
            this.extraerImagenesGroup.Controls.Add(this.label4);
            this.extraerImagenesGroup.Controls.Add(this.label3);
            this.extraerImagenesGroup.Controls.Add(this.textBoxExtraerImagenes);
            this.extraerImagenesGroup.Controls.Add(this.label2);
            this.extraerImagenesGroup.Controls.Add(this.extraerImagenesExportar);
            this.extraerImagenesGroup.Location = new System.Drawing.Point(7, 23);
            this.extraerImagenesGroup.Name = "extraerImagenesGroup";
            this.extraerImagenesGroup.Size = new System.Drawing.Size(164, 401);
            this.extraerImagenesGroup.TabIndex = 7;
            this.extraerImagenesGroup.TabStop = false;
            this.extraerImagenesGroup.Text = "Extraer imagenes cada X frames";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "por segundo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese un numero (decimal valido)";
            // 
            // textBoxExtraerImagenes
            // 
            this.textBoxExtraerImagenes.Location = new System.Drawing.Point(107, 323);
            this.textBoxExtraerImagenes.Name = "textBoxExtraerImagenes";
            this.textBoxExtraerImagenes.Size = new System.Drawing.Size(51, 20);
            this.textBoxExtraerImagenes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imagenes extraidas";
            // 
            // extraerImagenesExportar
            // 
            this.extraerImagenesExportar.Location = new System.Drawing.Point(83, 370);
            this.extraerImagenesExportar.Name = "extraerImagenesExportar";
            this.extraerImagenesExportar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.extraerImagenesExportar.Size = new System.Drawing.Size(75, 23);
            this.extraerImagenesExportar.TabIndex = 2;
            this.extraerImagenesExportar.Text = "Exportar";
            this.extraerImagenesExportar.UseVisualStyleBackColor = true;
            this.extraerImagenesExportar.Click += new System.EventHandler(this.extraerImagenesExportar_Click);
            // 
            // extraerAudioGroup
            // 
            this.extraerAudioGroup.Controls.Add(this.extraerAudioExportar);
            this.extraerAudioGroup.Location = new System.Drawing.Point(4, 19);
            this.extraerAudioGroup.Name = "extraerAudioGroup";
            this.extraerAudioGroup.Size = new System.Drawing.Size(172, 401);
            this.extraerAudioGroup.TabIndex = 8;
            this.extraerAudioGroup.TabStop = false;
            this.extraerAudioGroup.Text = "Extraer audio (en .mp3)";
            // 
            // extraerAudioExportar
            // 
            this.extraerAudioExportar.Location = new System.Drawing.Point(86, 366);
            this.extraerAudioExportar.Name = "extraerAudioExportar";
            this.extraerAudioExportar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.extraerAudioExportar.Size = new System.Drawing.Size(75, 23);
            this.extraerAudioExportar.TabIndex = 2;
            this.extraerAudioExportar.Text = "Exportar";
            this.extraerAudioExportar.UseVisualStyleBackColor = true;
            this.extraerAudioExportar.Click += new System.EventHandler(this.extraerAudioExportar_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 483);
            this.Controls.Add(this.extraerAudioGroup);
            this.Controls.Add(this.quitarAudioGroup);
            this.Controls.Add(this.cambiarFormatoBox);
            this.Controls.Add(this.extraerImagenesGroup);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cerrarArchivoButton);
            this.Controls.Add(this.labelArchivo);
            this.Controls.Add(this.resolucionGroup);
            this.Controls.Add(this.ExtraerImagenesButton);
            this.Controls.Add(this.ResolucionButton);
            this.Controls.Add(this.QuitarAudioButton);
            this.Controls.Add(this.ExtraerAudioButton);
            this.Controls.Add(this.FormatoButton);
            this.Controls.Add(this.menuStrip1);
            this.Name = "App";
            this.Text = "App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.resolucionGroup.ResumeLayout(false);
            this.resolucionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.quitarAudioGroup.ResumeLayout(false);
            this.cambiarFormatoBox.ResumeLayout(false);
            this.cambiarFormatoBox.PerformLayout();
            this.extraerImagenesGroup.ResumeLayout(false);
            this.extraerImagenesGroup.PerformLayout();
            this.extraerAudioGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.Button FormatoButton;
        private System.Windows.Forms.Button ExtraerAudioButton;
        private System.Windows.Forms.Button QuitarAudioButton;
        private System.Windows.Forms.Button ResolucionButton;
        private System.Windows.Forms.Button ExtraerImagenesButton;
        private System.Windows.Forms.GroupBox resolucionGroup;
        private OpenFileDialog archivoDialog;
        private Label labelArchivo;
        private Button cerrarArchivoButton;
        private ProgressBar progressBar1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private GroupBox quitarAudioGroup;
        private Button QuitarAudioExportar;
        private RadioButton flvButton;
        private RadioButton movButton;
        private RadioButton mpegButton;
        private RadioButton aviButton;
        private RadioButton mp4Button;
        private Label label1;
        private GroupBox cambiarFormatoBox;
        private Button cambiarFormatoExportar;
        private GroupBox extraerImagenesGroup;
        private GroupBox extraerAudioGroup;
        private Button extraerAudioExportar;
        private Button extraerImagenesExportar;
        private Button resolucionExportar;
        private Label label3;
        private TextBox textBoxExtraerImagenes;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label8;
        private TextBox TextBoxResolucionX;
        private Label label6;
        private Label label5;
        private TextBox TextBoxResolucionY;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}