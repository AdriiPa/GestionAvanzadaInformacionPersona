using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAvanzadaInformacionPersona
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

            timer1.Start();

            toolTip1 = new ToolTip();

            toolTip1.SetToolTip(btGuardar, "Guardar persona");
            toolTip1.SetToolTip(btLimpiar, "Limpiar TODO los datos");
            toolTip1.SetToolTip(btSalir, "Salir de la aplicacion");
            toolTip1.SetToolTip(tbDatosPers, "Datos Personales");
            toolTip1.SetToolTip(tbPreferencias, "Preferencias Usuario");
            toolTip1.SetToolTip(tbVisualizacion, "Visualizacion Imagen de perfil y hora actual");

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Esytas seguro que deseas salir del formulario", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("¿Quieres introducir estos datos?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes) {
                //Pestaña Datos Personales
                String nombre = txtNombre.Text;
                String direccion = txtDireccion.Text;
                String correo = txtCorreo.Text;
                String fechaNacimiento = mcEdad.SelectionRange.Start.ToString();
                String sexo = "";
                if (rbFemenino.Checked)
                {
                    sexo = "Femenino";
                }
                if (rbMasculino.Checked)
                {
                    sexo = "Masculino";
                }
                if (rbOtro.Checked)
                {
                    sexo = "Otre";
                }
                String edad = nudEdad.Text;

                //Pestaña Preferencias
                String boletin = "";
                if (chSubscripcion.Checked)
                {
                    boletin = "Subscripcion a boletin";
                }
                else
                {
                    boletin = "No tienes subscripcion al boletin";
                }

                String hobbies = " ";
                for (int i = 0; i < chbHobbies.Items.Count; i++)
                {
                    if (chbHobbies.GetItemChecked(i))
                    {
                        hobbies += chbHobbies.Items[i].ToString() + ",";
                    }
                }
                if (String.IsNullOrEmpty(hobbies))
                {
                    hobbies = "No tienes hobby";
                }


                String paisResidencia = cmbPais.SelectedItem.ToString();

                String satisfaccionServicio = trkbSatisfaccion.Value.ToString();

                //Persona para mostrar en el nuevo form
                Persona persona = new Persona
                {
                    Nombre = nombre,
                    Direccion = direccion,
                    Correo = correo,
                    FechaNacimiento = fechaNacimiento,
                    Sexo = sexo,
                    Edad = edad,
                    Boletin = boletin,
                    Hobbies = hobbies,
                    PaisResidencia = paisResidencia,
                    SatisfaccionServicio = satisfaccionServicio
                };

                txtDatosUser.Text = persona.ToString();
            }
                
                                             
           
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            mcEdad.SetSelectionRange(DateTime.Now, DateTime.Now);
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbOtro.Checked = false;
            nudEdad.Value = 0; 
            chSubscripcion.Checked = false;
            for (int i = 0; i < chbHobbies.Items.Count; i++)
            {
                chbHobbies.SetItemChecked(i, false);
            }
            cmbPais.SelectedIndex = -1; 
            trkbSatisfaccion.Value = 1; 
        }

        
    }
    
}

