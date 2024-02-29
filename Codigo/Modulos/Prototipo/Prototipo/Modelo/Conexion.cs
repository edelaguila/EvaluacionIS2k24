using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo_PrototipoMenu
{
    partial class Conexion
    {

        public OdbcConnection connection()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=siu");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("La base de datos no conectó");
            }
            return conn;
        }


        public void disconnect(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("La base de datos no desconectó");
            }
        }
    }

}
