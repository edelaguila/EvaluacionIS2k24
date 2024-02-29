using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaModelo_MG2
{
    public class Cita
    {
        public int Corre_cita { get; set; }
        public string Nombre { get; set; }
        public string dpi { get; set; }
        public DateTime fecha_i { get; set; }
        public Cita(int crr, DateTime fecha)
        {
            this.Corre_cita = crr;
            this.fecha_i = fecha;
        }

        public Cita(int corre_cita, string nombre, string dpi, DateTime fecha_i)
        {
            Corre_cita = corre_cita;
            Nombre = nombre;
            this.dpi = dpi;
            this.fecha_i = fecha_i;
        }
    }
}
