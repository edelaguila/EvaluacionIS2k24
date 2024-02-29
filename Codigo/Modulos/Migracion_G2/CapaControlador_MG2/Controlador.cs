using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo_MG2;
using System.Data.Odbc;
using System.Data;
using System;
using CapaModelo_MG2.Sentences;



namespace CapaControlador_MG2
{

    public class Controlador
    {
        Sentencias sn = new Sentencias();
        public CitaSentence sn_cita = new CitaSentence();
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void updateCita(int correlativo, DateTime nuevaFecha)
        {
            Console.WriteLine("Controlador");
            this.sn_cita.update(new Cita(correlativo, nuevaFecha));
        }

    }
}
