using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace CapaModelo_MG2.Sentences
{
    public class CitaSentence : Sentencias
    {
        public void update(Cita cita)
        {
            try
            {
                string query = "update cita set fecha_i='" + cita.fecha_i.ToString("yyyy/MM/dd") + "' where Corre_cita='" + cita.Corre_cita + "'";
                this.executerCommand(query);
                MessageBox.Show("Actualizado Correctamente");
            }
            catch (OdbcException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
