using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_PrototipoMenu
{
    public class Conexion
    {
        //Andrea Cecilia Corado Paiz 0901-20-2841 29-02-2024
        public OdbcConnection connection()
        {
            //Se realiza la conexión al odbc para poder usar la base de datos
            OdbcConnection conn = new OdbcConnection("Dsn=HotelSConexion");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            //por si no se llego a conectar
            {
                Console.WriteLine("No Conectó");
            }
            return conn;
        }


        public void disconnect(OdbcConnection conn)
        {
            //por si no se llego a conectar en el proceso del programa
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No desconectó");
            }
        }
    }

}
