using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_PrototipoMenu
{
        public class Persona
        {
            public string Nombre { get; set; }
            public string PrimerApellido { get; set; }
            public string SegundoApellido { get; set; }
            public string ApellidoCasado { get; set; }
            public DateTime FechaNacimiento { get; set; }
            public string TipoDocumento { get; set; }
            public int NumDocumento { get; set; }
            public string Nacionalidad { get; set; }
            public string Genero { get; set; }
            public string EstadoCivil { get; set; }
            public string Direccion { get; set; }
            public string Celular { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }
            public string ConfCorreo { get; set; }
            public int Altura { get; set; }
            public string Tez { get; set; }
            public string Ojos { get; set; }
            public string Ocupacion { get; set; }
        public int dpi;
        public Persona()
        {
            Nombre = "";
            PrimerApellido = "";
            SegundoApellido = "";
            ApellidoCasado = "";
            FechaNacimiento = new DateTime();
            TipoDocumento = "";
            NumDocumento = 1;
            Nacionalidad = "";
            Genero = "";
            EstadoCivil = "";
            Direccion = "";
            Celular = "";
            Telefono = "";
            Correo = "";
            ConfCorreo = "";
            Altura = 1;
            Tez = "";
            Ojos = "";
            Ocupacion = "";
        }

            public Persona(string nombre, string primerApellido, string segundoApellido, string apellidoCasado, DateTime fechaNacimiento, string tipoDocumento, int numDocumento, string nacionalidad, string genero, string estadoCivil, string direccion, string celular, string telefono, string correo, string confCorreo, int altura, string tez, string ojos, string ocupacion, int dpi)
            {
            this.dpi = dpi;
                Nombre = nombre;
                PrimerApellido = primerApellido;
                SegundoApellido = segundoApellido;
                ApellidoCasado = apellidoCasado;
                FechaNacimiento = fechaNacimiento;
                TipoDocumento = tipoDocumento;
                NumDocumento = numDocumento;
                Nacionalidad = nacionalidad;
                Genero = genero;
                EstadoCivil = estadoCivil;
                Direccion = direccion;
                Celular = celular;
                Telefono = telefono;
                Correo = correo;
                ConfCorreo = confCorreo;
                Altura = altura;
                Tez = tez;
                Ojos = ojos;
                Ocupacion = ocupacion;
            }
        }
}
