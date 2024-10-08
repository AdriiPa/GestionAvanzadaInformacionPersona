namespace GestionAvanzadaInformacionPersona
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
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDatosPers = new System.Windows.Forms.TabPage();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.mcEdad = new System.Windows.Forms.MonthCalendar();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbOtro = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbPreferencias = new System.Windows.Forms.TabPage();
            this.lbSatisfaccion = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chbHobbies = new System.Windows.Forms.CheckedListBox();
            this.chSubscripcion = new System.Windows.Forms.CheckBox();
            this.lblSubs = new System.Windows.Forms.Label();
            this.tbVisualizacion = new System.Windows.Forms.TabPage();
            this.trkbSatisfaccion = new System.Windows.Forms.TrackBar();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbDatosPers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.panel2.SuspendLayout();
            this.tbPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbSatisfaccion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDatosPers);
            this.tabControl1.Controls.Add(this.tbPreferencias);
            this.tabControl1.Controls.Add(this.tbVisualizacion);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 332);
            this.tabControl1.TabIndex = 0;
            // 
            // tbDatosPers
            // 
            this.tbDatosPers.BackColor = System.Drawing.Color.PaleGreen;
            this.tbDatosPers.Controls.Add(this.nudEdad);
            this.tbDatosPers.Controls.Add(this.lbEdad);
            this.tbDatosPers.Controls.Add(this.lblNacimiento);
            this.tbDatosPers.Controls.Add(this.mcEdad);
            this.tbDatosPers.Controls.Add(this.txtCorreo);
            this.tbDatosPers.Controls.Add(this.txtDireccion);
            this.tbDatosPers.Controls.Add(this.txtNombre);
            this.tbDatosPers.Controls.Add(this.panel2);
            this.tbDatosPers.Controls.Add(this.lblCorreo);
            this.tbDatosPers.Controls.Add(this.lblDireccion);
            this.tbDatosPers.Controls.Add(this.lblNombre);
            this.tbDatosPers.Location = new System.Drawing.Point(4, 24);
            this.tbDatosPers.Name = "tbDatosPers";
            this.tbDatosPers.Padding = new System.Windows.Forms.Padding(3);
            this.tbDatosPers.Size = new System.Drawing.Size(789, 304);
            this.tbDatosPers.TabIndex = 0;
            this.tbDatosPers.Text = "Datos Personales";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(454, 141);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 21);
            this.nudEdad.TabIndex = 11;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(403, 141);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(44, 15);
            this.lbEdad.TabIndex = 10;
            this.lbEdad.Text = "Edad:";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(3, 105);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(149, 15);
            this.lblNacimiento.TabIndex = 9;
            this.lblNacimiento.Text = "Fecha de nacimiento: ";
            // 
            // mcEdad
            // 
            this.mcEdad.Location = new System.Drawing.Point(164, 105);
            this.mcEdad.Name = "mcEdad";
            this.mcEdad.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(142, 68);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(209, 21);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(80, 42);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(224, 21);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(80, 12);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 21);
            this.txtNombre.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSexo);
            this.panel2.Controls.Add(this.rbFemenino);
            this.panel2.Controls.Add(this.rbOtro);
            this.panel2.Controls.Add(this.rbMasculino);
            this.panel2.Location = new System.Drawing.Point(403, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 4;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(4, 4);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 15);
            this.lblSexo.TabIndex = 3;
            this.lblSexo.Text = "Sexo";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(3, 44);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(89, 19);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbOtro
            // 
            this.rbOtro.AutoSize = true;
            this.rbOtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOtro.Location = new System.Drawing.Point(3, 67);
            this.rbOtro.Name = "rbOtro";
            this.rbOtro.Size = new System.Drawing.Size(52, 19);
            this.rbOtro.TabIndex = 2;
            this.rbOtro.TabStop = true;
            this.rbOtro.Text = "Otro";
            this.rbOtro.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(3, 21);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(91, 19);
            this.rbMasculino.TabIndex = 0;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(2, 70);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(134, 15);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo Electronico: ";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(2, 42);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(72, 15);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(3, 12);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre: ";
            // 
            // tbPreferencias
            // 
            this.tbPreferencias.BackColor = System.Drawing.Color.LightGreen;
            this.tbPreferencias.Controls.Add(this.trkbSatisfaccion);
            this.tbPreferencias.Controls.Add(this.lbSatisfaccion);
            this.tbPreferencias.Controls.Add(this.lbPais);
            this.tbPreferencias.Controls.Add(this.cmbPais);
            this.tbPreferencias.Controls.Add(this.label1);
            this.tbPreferencias.Controls.Add(this.chbHobbies);
            this.tbPreferencias.Controls.Add(this.chSubscripcion);
            this.tbPreferencias.Controls.Add(this.lblSubs);
            this.tbPreferencias.Location = new System.Drawing.Point(4, 24);
            this.tbPreferencias.Name = "tbPreferencias";
            this.tbPreferencias.Padding = new System.Windows.Forms.Padding(3);
            this.tbPreferencias.Size = new System.Drawing.Size(789, 304);
            this.tbPreferencias.TabIndex = 1;
            this.tbPreferencias.Text = "Preferencias";
            // 
            // lbSatisfaccion
            // 
            this.lbSatisfaccion.AutoSize = true;
            this.lbSatisfaccion.Location = new System.Drawing.Point(532, 41);
            this.lbSatisfaccion.Name = "lbSatisfaccion";
            this.lbSatisfaccion.Size = new System.Drawing.Size(235, 15);
            this.lbSatisfaccion.TabIndex = 6;
            this.lbSatisfaccion.Text = "Nivel de satisfaccion con el servicio";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(273, 41);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(130, 15);
            this.lbPais.TabIndex = 5;
            this.lbPais.Text = "Pais de residencia:";
            // 
            // cmbPais
            // 
            this.cmbPais.AutoCompleteCustomSource.AddRange(new string[] {
            "España",
            "Francia",
            "Reino Unido",
            "Estados Unidos",
            "Colombia ",
            "Argentina",
            "Portugal",
            "Andorra",
            "Marruecos"});
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Location = new System.Drawing.Point(276, 59);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 23);
            this.cmbPais.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hobbies o Intereses";
            // 
            // chbHobbies
            // 
            this.chbHobbies.FormattingEnabled = true;
            this.chbHobbies.Items.AddRange(new object[] {
            "Deportes",
            "Juegos Online",
            "Cine",
            "Cocina",
            "Viajar",
            "Fiesta",
            "Fotografia"});
            this.chbHobbies.Location = new System.Drawing.Point(10, 59);
            this.chbHobbies.Name = "chbHobbies";
            this.chbHobbies.Size = new System.Drawing.Size(184, 116);
            this.chbHobbies.TabIndex = 2;
            // 
            // chSubscripcion
            // 
            this.chSubscripcion.AutoSize = true;
            this.chSubscripcion.Location = new System.Drawing.Point(166, 7);
            this.chSubscripcion.Name = "chSubscripcion";
            this.chSubscripcion.Size = new System.Drawing.Size(106, 19);
            this.chSubscripcion.TabIndex = 1;
            this.chSubscripcion.Text = "Subscribirse";
            this.chSubscripcion.UseVisualStyleBackColor = true;
            // 
            // lblSubs
            // 
            this.lblSubs.AutoSize = true;
            this.lblSubs.Location = new System.Drawing.Point(7, 7);
            this.lblSubs.Name = "lblSubs";
            this.lblSubs.Size = new System.Drawing.Size(152, 15);
            this.lblSubs.TabIndex = 0;
            this.lblSubs.Text = "¿Sucribirse al boletin?";
            // 
            // tbVisualizacion
            // 
            this.tbVisualizacion.Location = new System.Drawing.Point(4, 24);
            this.tbVisualizacion.Name = "tbVisualizacion";
            this.tbVisualizacion.Size = new System.Drawing.Size(789, 304);
            this.tbVisualizacion.TabIndex = 2;
            this.tbVisualizacion.Text = "Visualizacion";
            this.tbVisualizacion.UseVisualStyleBackColor = true;
            // 
            // trkbSatisfaccion
            // 
            this.trkbSatisfaccion.Location = new System.Drawing.Point(535, 79);
            this.trkbSatisfaccion.Minimum = 1;
            this.trkbSatisfaccion.Name = "trkbSatisfaccion";
            this.trkbSatisfaccion.Size = new System.Drawing.Size(232, 45);
            this.trkbSatisfaccion.TabIndex = 7;
            this.trkbSatisfaccion.Value = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Gestion Avanzada de informacion Personal";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbDatosPers.ResumeLayout(false);
            this.tbDatosPers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tbPreferencias.ResumeLayout(false);
            this.tbPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkbSatisfaccion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDatosPers;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.MonthCalendar mcEdad;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbOtro;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TabPage tbPreferencias;
        private System.Windows.Forms.Label lblSubs;
        private System.Windows.Forms.TabPage tbVisualizacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chbHobbies;
        private System.Windows.Forms.CheckBox chSubscripcion;
        private System.Windows.Forms.Label lbSatisfaccion;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.TrackBar trkbSatisfaccion;
    }
}

