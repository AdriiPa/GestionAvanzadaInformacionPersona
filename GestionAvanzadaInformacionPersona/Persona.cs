using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAvanzadaInformacionPersona
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public string Edad { get; set; }
        public string Boletin { get; set; }
        public string Hobbies { get; set; }
        public string PaisResidencia { get; set; }
        public string SatisfaccionServicio { get; set; }

        public Persona() { }
        public override string ToString()
        {
            return $"Nombre: {Nombre}\n" +
                   $"Dirección: {Direccion}\n" +
                   $"Correo: {Correo}\n" +
                   $"Fecha de Nacimiento: {FechaNacimiento}\n" +
                   $"Sexo: {Sexo}\n" +
                   $"Edad: {Edad}\n" +
                   $"Boletín: {Boletin}\n" +
                   $"Hobbies: {Hobbies}\n" +
                   $"País de Residencia: {PaisResidencia}\n" +
                   $"Satisfacción del Servicio: {SatisfaccionServicio}";
        }
    }
}
