using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Modelo_PrototipoMenu
{
    //Para la reagendacion de citas
    public class Cita
    {
        public int Pk_id_cita { get; set; }
        public string cit_fecha { get; set; }
        public string cit_hora { get; set; }
        public string cit_dept { get; set; }
        public string cit_ciudad { get; set; }
        public int tbl_documento_Pk_num_dpi { get; set; }
        public int tbl_boleta_Pk_No_Boleta { get; set; }
        public int tbl_CGC_Pk_no_cgc { get; set; }
    }

    public class Boleta
    {
        public int Pk_id_boleta { get; set; }
        public string boleta_concepto { get; set; }
        public string boleta_tipoPago { get; set; }
        public int id_tipopasaporte { get; set; }
        public int boleta_añosDuracion { get; set; }
        public int boleta_numeroDoc { get; set; }
        public int tbl_cgc_Pk_no_cgc { get; set; }
        public int tbl_documento_Pk_num_dpi { get; set; }
    }

    public class VerificarDatos
    {
        public int Pk_id_boleta { get; set; }
        public string boleta_concepto { get; set; }
        public string boleta_tipoPago { get; set; }
        public int id_tipopasaporte { get; set; }
        public int boleta_añosDuracion { get; set; }
        public int boleta_numeroDoc { get; set; }
        public int tbl_cgc_Pk_no_cgc { get; set; }
        public int tbl_documento_Pk_num_dpi { get; set; }

    }

    public class Sentencias
    {
        Conexion con = new Conexion();

        public bool InsertarDocumento(long dpi, string numdoc, string nacionalidad, string genero, string estadocivil, string nombre, string Papellido, string Sappelido, string fechaNacimiento, string Capellido)
        {
            string insertQueryDocumento = getQueryDocumento(dpi,  numdoc, nacionalidad, genero, estadocivil, nombre, Papellido, Sappelido, fechaNacimiento, Capellido);
            using (OdbcConnection conn = con.connection())
            {
                using (OdbcCommand cmd = new OdbcCommand(insertQueryDocumento, conn))
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public string getQueryDocumento(long dpi, string numdoc, string nacionalidad, string genero, string estadocivil, string nombre, string Papellido, string Sappelido, string fechaNacimiento, string Capellido)
        {
            string sql = "INSERT INTO tbl_documento(Pk_num_dpi, doc_dpi,doc_nacionalidad,doc_genero,doc_estadocivil,doc_nombres,doc_primerapellido,doc_segundoapellido,doc_fechanacimiento,doc_casadoapellido)VALUES('" + dpi + "','" + numdoc + "', '" + nacionalidad + "', '" + genero + "', '" + estadocivil + "', '" + nombre + "', '" + Papellido + "', '" + Sappelido + "', '" + fechaNacimiento + "', '" + Capellido + "')";
            return sql;
        }

        public bool InsertarDatosPersonales(string nombre, string Papellido, string Sappelido, string fechaNacimiento, string direccion, string celular, string telefono, string correo, string confcorreo, string altura, string tez, string ojos, string ocupacion, string Capellido, long dpi)
        {
            string insertQueryDatosPersonales = getQueryDatosPersonales(nombre, Papellido, Sappelido, fechaNacimiento, direccion, celular, telefono, correo, confcorreo, altura, tez, ojos, ocupacion, Capellido,  dpi);
            using (OdbcConnection conn = con.connection())
            {
                using (OdbcCommand cmd = new OdbcCommand(insertQueryDatosPersonales, conn))
                {
                    try
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        return false;
                    }
                }
            }
        }

        public string getQueryDatosPersonales(string nombre, string Papellido, string Sappelido, string fechaNacimiento, string direccion, string celular, string telefono, string correo, string confcorreo, string altura, string tez, string ojos, string ocupacion, string Capellido, long dpi)
        {
            string sql = "INSERT INTO tbl_datospersonales(Pk_id,dp_nombre,dp_primerapellido,dp_segundoapellido,dp_fechanac,dp_dirResidencia,dp_celular,dp_telefono,dp_correo,dp_correoconfir,dp_alturacm,dp_tez,dp_ojos,dp_ocupacion,dp_casadoapellido,tbl_documento_Pk_num_dpi)VALUES(default,'" + nombre + "', '" + Papellido + "', '" + Sappelido + "', '" + fechaNacimiento + "', '" + direccion + "', '" + celular + "', '" + telefono + "', '" + correo + "', '" + confcorreo + "', '" + altura + "', '" + tez + "', '" + ojos + "', '" + ocupacion + "', '"+Capellido+"', '" + dpi + "')";
            return sql;
        }
        //Insertar Cita
        public void InsertarCita(int idCita, string fecha, string hora, string dept, string ciudad, int idBoleta, int numDPI, int noCGC)
        {
            using (OdbcConnection conn = con.connection())
            {
                try
                {
                    conn.Close();
                    conn.Open();

                    string consulta = "INSERT INTO tbl_cita (Pk_id_cita, cit_fecha, cit_hora, cit_dept, cit_ciudad, tbl_boleta_Pk_id_boleta, tbl_documento_Pk_num_dpi, tbl_CGC_Pk_no_cgc) VALUES (?, ?, ?, ?, ?, ?, ?, ?)";

                    using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@IdCita", idCita);
                        cmd.Parameters.AddWithValue("@Fecha", fecha);
                        cmd.Parameters.AddWithValue("@Hora", hora);
                        cmd.Parameters.AddWithValue("@Dept", dept);
                        cmd.Parameters.AddWithValue("@Ciudad", ciudad);
                        cmd.Parameters.AddWithValue("@IdBoleta", idBoleta);
                        cmd.Parameters.AddWithValue("@NumDPI", numDPI);
                        cmd.Parameters.AddWithValue("@NoCGC", noCGC);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            Console.WriteLine("Inserción exitosa.");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo insertar la cita.");
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al insertar la cita: " + ex.Message);
                }
            }
        }
        //fin insertar cita


        //Existencia de la cita a reagendar
        public Cita BuscarCita(int noBoleta, int noDocumento, int noCGC)
        {
            Cita citaEncontrada = null;
            int Citanum ;
            using (OdbcConnection conn = con.connection())
            {
                try
                {
                    conn.Close();
                    conn.Open();

                    string consulta = "SELECT Pk_id_cita, cit_fecha, cit_hora, cit_dept, cit_ciudad, tbl_boleta_Pk_id_boleta, tbl_documento_Pk_num_dpi, tbl_CGC_Pk_no_cgc FROM tbl_cita WHERE tbl_boleta_Pk_id_boleta = ? AND tbl_documento_Pk_num_dpi = ? AND tbl_CGC_Pk_no_cgc = ?";
                    using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@NoBoleta", noBoleta);
                        cmd.Parameters.AddWithValue("@NoDocumento", noDocumento);
                        cmd.Parameters.AddWithValue("@NoCGC", noCGC);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                citaEncontrada = new Cita
                                {
                                    Pk_id_cita = Convert.ToInt32(reader["Pk_id_cita"]),
                                    cit_fecha = reader["cit_fecha"].ToString(),
                                    cit_hora = reader["cit_hora"].ToString(),
                                    cit_dept = reader["cit_dept"].ToString(),
                                    cit_ciudad = reader["cit_ciudad"].ToString(),
                                      

                                };
                                Citanum = Convert.ToInt32(reader["Pk_id_cita"]);
                                Console.WriteLine("Numero de cita es : " + Citanum);

                            }
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Cita no encontrada verificar datos: " + ex.Message);
                }
            }

            return citaEncontrada;
        }
        //Fin Existencia de la cita a reagendar
        //actaulizar cita

        public bool ActualizarCita(int numeroCita, string nuevaFecha, string nuevaHora, string nuevoDept, string nuevoMunicipio)
        {
            bool citaActualizada = false;

            using (OdbcConnection conn = con.connection())
            {
                try
                {
                    conn.Close();
                    conn.Open();

                    string consulta = "UPDATE tbl_cita SET cit_fecha = ?, cit_hora = ?, cit_dept = ?, cit_ciudad = ? WHERE Pk_id_cita = ?";

                    using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@CitFecha", nuevaFecha);
                        cmd.Parameters.AddWithValue("@CitHora", nuevaHora);
                        cmd.Parameters.AddWithValue("@CitDept", nuevoDept);
                        cmd.Parameters.AddWithValue("@CitCiudad", nuevoMunicipio);
                        cmd.Parameters.AddWithValue("@PkIdCita", numeroCita);

                        int filasActualizadas = cmd.ExecuteNonQuery();

                        if (filasActualizadas > 0)
                        {
                            citaActualizada = true;
                            Console.WriteLine("Cita actualizada correctamente");
                        }
                        else
                        {
                            Console.WriteLine("No se pudo actualizar la cita");
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Error al actualizar la cita: " + ex.Message);
                }
            }

            return citaActualizada;
        }
        //fin actualizar cita


        //sentencias para generacion de boleta 
        //carlos enrique y diego antonio

        public List<string> llenarCombo(string columna1, string tabla)
        {
            List<string> datos = new List<string>();
            try
            {

                string consulta = $"SELECT {columna1} FROM {tabla}";

                OdbcCommand command = new OdbcCommand(consulta, con.connection());
                OdbcDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string ID = reader[columna1].ToString();
                    datos.Add(ID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return datos;
        }

        public DataTable Buscar(string tabla, string columna, string dato)
        {
            string consulta = $"SELECT * FROM {tabla} WHERE {columna} = '{dato}'";
            OdbcDataAdapter datos = new OdbcDataAdapter(consulta, con.connection());

            DataTable dt = new DataTable();
            datos.Fill(dt);

            return dt;
        }

        public bool Guardar(string tabla, Dictionary<string, object> valores)
        {
            
            
                using (OdbcConnection conn = con.connection())
                {
                    string columnas = string.Join(", ", valores.Keys);
                    string parametros = string.Join(", ", valores.Keys.Select(key => "?"));
                    string consulta = $"INSERT INTO {tabla} ({columnas}) VALUES ({parametros})";

                    using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                    {
                        foreach (var kvp in valores)
                        {
                            cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                        }

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        return filasAfectadas > 0;
                    }
                }
          
           
        }

        public void ValidarDatos(int id, string dp_nombre, string dp_primerapellido, string dp_segundoapellido, DateTime dp_fechanac, string dp_dirResidencia, int dp_celular, int dp_telefono, string dp_correo, string dp_correoconfir, int dp_alturacm, string dp_tez, string dp_ojos, string dp_ocupacion, string dp_casadoapellido)
        {
            using (OdbcConnection connection = con.connection())
            {
                if (connection != null)
                {
                    using (OdbcTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = "INSERT INTO tbl_datospersonales (`Pk_id`, `dp_nombre`, `dp_primerapellido`, `dp_segundoapellido`,´dp_fechanac´,´dp_dirResidencia´,´dp_celular´,´dp_telefono´,´dp_correo´,´dp_correoconfir,´dp_alturacm´,´dp_tez´,´dp_ojos´,´dp_ocupacion´,´dp_casadoapellido´) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
                            using (OdbcCommand cmd = new OdbcCommand(insertQuery, connection, transaction))
                            {
                                cmd.Parameters.AddWithValue("@Pk_id", id);
                                cmd.Parameters.AddWithValue("@dp_nombre", dp_nombre);
                                cmd.Parameters.AddWithValue("@dp_primerapellido", dp_primerapellido);
                                cmd.Parameters.AddWithValue("@dp_segundoapellido", dp_segundoapellido);
                                cmd.Parameters.AddWithValue("@dp_fechanac", dp_fechanac);
                                cmd.Parameters.AddWithValue("@dp_dirResidencia", dp_dirResidencia);
                                cmd.Parameters.AddWithValue("@dp_celular", dp_celular);
                                cmd.Parameters.AddWithValue("@dp_telefono", dp_telefono);
                                cmd.Parameters.AddWithValue("@dp_correo", dp_correo);
                                cmd.Parameters.AddWithValue("@dp_correoconfir", dp_correoconfir);
                                cmd.Parameters.AddWithValue("@dpalturacm", dp_alturacm);
                                cmd.Parameters.AddWithValue("@dp_tez", dp_tez);
                                cmd.Parameters.AddWithValue("@dp_ojos", dp_ojos);
                                cmd.Parameters.AddWithValue("@dp_ocupacion", dp_ocupacion);
                                cmd.Parameters.AddWithValue("@dp_casadoapellido", dp_casadoapellido);

                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            Console.WriteLine($"Error al Validar Datos: {ex.Message}");
                        }
                    }
                }
            }
        }

        private void GuardarDatos(int id, string dp_nombre, string dp_primerapellido, string dp_segundoapellido, DateTime dp_fechanac, string dp_dirResidencia, int dp_celular, int dp_telefono, string dp_correo, string dp_correoconfir, int dp_alturacm, string dp_tez, string dp_ojos, string dp_ocupacion, string dp_casadoapellido)
        {
            /*
        using (OdbcConnection connection = con.connection())
        {
            string query = "INSERT INTO tbl_datospersonales (nombre, primerApellido, segundoApellido, apellidoCasado, fechaNacimiento, tipoDocumento, numDocumento, nacionalidad, genero, estadoCivil, direccion, celular, telefono, correo, altura, tez, ojos, ocupacion) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
            using (OdbcCommand command = new OdbcCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Pk_id", id);
                cmd.Parameters.AddWithValue("@dp_nombre", dp_nombre);
                cmd.Parameters.AddWithValue("@dp_primerapellido", dp_primerapellido);
                cmd.Parameters.AddWithValue("@dp_segundoapellido", dp_segundoapellido);
                cmd.Parameters.AddWithValue("@dp_fechanac", dp_fechanac);
                cmd.Parameters.AddWithValue("@dp_dirResidencia", dp_dirResidencia);
                cmd.Parameters.AddWithValue("@dp_celular", dp_celular);
                cmd.Parameters.AddWithValue("@dp_telefono", dp_telefono);
                cmd.Parameters.AddWithValue("@dp_correo", dp_correo);
                cmd.Parameters.AddWithValue("@dp_correoconfir", dp_correoconfir);
                cmd.Parameters.AddWithValue("@dpalturacm", dp_alturacm);
                cmd.Parameters.AddWithValue("@dp_tez", dp_tez);
                cmd.Parameters.AddWithValue("@dp_ojos", dp_ojos);
                cmd.Parameters.AddWithValue("@dp_ocupacion", dp_ocupacion);
                cmd.Parameters.AddWithValue("@dp_casadoapellido", dp_casadoapellido);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }*/
        }

        public bool GuardarCGC(string table, Dictionary<string, object> vals)
        {
            using (OdbcConnection conn = con.connection())
            {

              
                string columnas = string.Join(", ", vals.Keys);
                string parametros = string.Join(", ", vals.Keys.Select(key => "?"));
                string consult = $"INSERT INTO {table} ({columnas}) VALUES ({parametros})";

                using (OdbcCommand cmd = new OdbcCommand(consult, conn))
                {
                    foreach (var kvp in vals)
                    {
                        cmd.Parameters.AddWithValue(kvp.Key, kvp.Value);
                    }

                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }

        public Boleta BuscarBoleta(int noBoleta, int noCGC)
        {
            Boleta boletaEncontrada = null;

            using (OdbcConnection conn = con.connection())
            {
                try
                {
                    conn.Close();
                    conn.Open();

                    string consulta = "SELECT Pk_id_boleta, boleta_concepto, boleta_tipoPago, id_tipopasaporte, boleta_añosDuracion, boleta_numeroDoc, tbl_cgc_Pk_no_cgc, tbl_documento_Pk_num_dpi FROM tbl_boleta WHERE Pk_id_boleta = ? AND tbl_cgc_Pk_no_cgc = ?";

                    using (OdbcCommand cmd = new OdbcCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@NoBoleta", noBoleta);
                        cmd.Parameters.AddWithValue("@NoCGC", noCGC);

                        using (OdbcDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                boletaEncontrada = new Boleta
                                {
                                    Pk_id_boleta = Convert.ToInt32(reader["Pk_id_boleta"]),
                                    tbl_cgc_Pk_no_cgc = Convert.ToInt32(reader["tbl_cgc_Pk_no_cgc"]),
                                };
                            }
                        }
                    }
                }
                catch (OdbcException ex)
                {
                    Console.WriteLine("Boleta no encontrada verificar datos: " + ex.Message);
                }
            }

            return boletaEncontrada;
        }





    }
    
}
