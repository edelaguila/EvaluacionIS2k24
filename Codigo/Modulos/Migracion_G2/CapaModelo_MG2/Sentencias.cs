using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;


namespace CapaModelo_MG2
{

    public class Sentencias
    {

        protected Conexion con;
        private static string baseDatos = "";
        public Sentencias()
        {
            this.con = new Conexion();
            baseDatos = this.con.connection().Database;
        }
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.connection());
            return dataTable;
        }


        public void executerCommand(string query)
        {
            Console.WriteLine("Creating command");
            OdbcCommand mycommand = new OdbcCommand(query, con.connection());
            Console.WriteLine("Before execute");
            mycommand.ExecuteNonQuery();
        }


    }

}
