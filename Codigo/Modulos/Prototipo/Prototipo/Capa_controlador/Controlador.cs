using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo_PrototipoMenu;
using System.Data.Odbc;
using System.Data;

namespace Controlador_PrototipoMenu
{
    public class Controlador
    {
        public Sentencias sn;

        public Controlador()
        {
            sn = new Sentencias();
        }

        public void CargarOpcionesGenero(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Masculino");
            combo.Items.Add("Femenino");
        }
        public void CargarOpcionesEstado(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Soltero");
            combo.Items.Add("Casado");
        }

        public void CargarOpcionesTez(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Clara");
            combo.Items.Add("Media");
            combo.Items.Add("Oscura");
            combo.Items.Add("Muy Oscura");
        }

        public void CargarOpcionesOjos(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Azul");
            combo.Items.Add("Verde");
            combo.Items.Add("Marrón");
            combo.Items.Add("Avellana");
            combo.Items.Add("Gris");
            combo.Items.Add("Negro");
        }
        public void CargarOpcionesOcupacion(ComboBox combo)
        {
            // Aquí proporciona las opciones al ComboBox
            combo.Items.Add("Estudiante");
            combo.Items.Add("Empleado/a");
            combo.Items.Add("Trabajador/a independiente");
            combo.Items.Add("Empresario/a");
            combo.Items.Add("Desempleado/a");
            combo.Items.Add("Jubilado/a");
            combo.Items.Add("Amo/a de casa");
            combo.Items.Add("Militar");
            combo.Items.Add("Funcionario/a público/a");
            combo.Items.Add("Profesional");
            combo.Items.Add("Artista");
            combo.Items.Add("Agricultor/a");
            combo.Items.Add("Otra");
        }

        public bool InsertarDocumento(long dpi, string numdoc, string nacionalidad, string genero, string estadocivil, string nombre, string Papellido, string Sappelido, string fechaNacimiento, string Capellido)
        {
            return sn.InsertarDocumento(dpi,  numdoc, nacionalidad, genero, estadocivil, nombre, Papellido, Sappelido, fechaNacimiento, Capellido);
        }

        public bool InsertarDatosPersonales(string nombre, string Papellido, string Sappelido, string fechaNacimiento, string direccion, string celular, string telefono, string correo, string confcorreo, string altura, string tez, string ojos, string ocupacion, string Capellido, long numdoc)
        {
            return sn.InsertarDatosPersonales(nombre, Papellido, Sappelido, fechaNacimiento, direccion, celular, telefono, correo, confcorreo, altura, tez, ojos, ocupacion, Capellido, numdoc);
        }
        //insertarcita
        public void InsertarCitas(int idCita, string fecha, string hora, string dept, string ciudad, int idBoleta, int numDPI, int noCGC)
        {
            sn.InsertarCita(idCita, fecha, hora, dept, ciudad, idBoleta, numDPI, noCGC);
        }

        //insertarcita


        //buscar cita existente a reagendar
        public int Citanum;

        public bool BuscarCita(int noBoleta, int noDocumento, int noCGC)
        {
            Cita cita = sn.BuscarCita(noBoleta, noDocumento, noCGC);
            if (cita != null)
            {
                Citanum = cita.Pk_id_cita;
                Console.WriteLine("citabusque:" + Citanum);
            }

            return cita != null;
        }

        public bool DatosValidos(int noBoleta, int noDocumento, int noCGC)
        {
            Sentencias sentencias = new Sentencias();
            Cita cita = sentencias.BuscarCita(noBoleta, noDocumento, noCGC);

            Console.WriteLine("datavaltcitanum:" + Citanum);

            return cita != null &&
                   cita.tbl_boleta_Pk_No_Boleta == noBoleta &&
                   cita.tbl_documento_Pk_num_dpi == noDocumento &&
                   cita.tbl_CGC_Pk_no_cgc == noCGC;
        }

        public int ObtenerCitaNum()
        {
            Console.WriteLine("obtenercitanum:" + Citanum);
            return Citanum;
        }
        //Fin Existencia de la cita a reagendar

        //actualizar cita

        public bool ActualizarCitas(int numeroCita, string nuevaFecha, string nuevaHora, string nuevoDept, string nuevoMunicipio)
         {
             return sn.ActualizarCita( numeroCita, nuevaFecha, nuevaHora,  nuevoDept,  nuevoMunicipio);
         }

        //generacion de boleta
        //carlos enrique y diego antonio

        public List<string> llenarCombo(string columna1, string tabla)
        {
            return sn.llenarCombo(columna1, tabla);
        }

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            return sn.Buscar(tabla, columna, dato);

        }

        public bool GuardarDatos(string tabla,  Dictionary<string, object> valores)
        {
            return sn.Guardar(tabla,  valores);
        }

        public bool GuardarDatosCGC(string table, Dictionary<string, object> vals)
        {
            return sn.Guardar(table, vals);
        }

        public bool BuscarYMostrarBoleta(int noBoleta, int noCGC)
        {
            Boleta boletaEncontrada = sn.BuscarBoleta(noBoleta, noCGC);

            if (boletaEncontrada != null)
            {
                Console.WriteLine("Número de boleta: " + boletaEncontrada.Pk_id_boleta);



                return true;
            }
            else
            {
                Console.WriteLine("No se encontró la boleta en la base de datos.");
                return false;
            }
        }


    }
}
