using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_PrototipoMenu;
// carlos enrique guzman cabrera

namespace Vista_PrototipoMenu
{
    public partial class frmConfirmacionBoleta : Form
    {
        Controlador cn = new Controlador();
        public frmConfirmacionBoleta()
        {
            InitializeComponent();
          
        }

        public void GuardarDatos()
        {
            string tabla = "tbl_boleta";
            string table = "tbl_cgc";

            Dictionary<string, object> valores = new Dictionary<string, object>();
            Dictionary<string, object> vals = new Dictionary<string, object>();

  
            valores.Add("boleta_concepto", txt_conceptoBoleta.Text);
            valores.Add("Pk_id_boleta", int.Parse(txt_NoBoletaSelet.Text));
            valores.Add("boleta_tipoPago", txt_tipoBoleta.Text);
            valores.Add("id_tipopasaporte", int.Parse(txt_IDPasaporte.Text));
            valores.Add("boleta_añosDuracion", int.Parse(txt_pagoAños.Text));
            valores.Add("tbl_documento_Pk_num_dpi", long.Parse(txt_IDPersona.Text));
            valores.Add("boleta_numeroDoc", int.Parse(txt_NoBoletaSelet.Text));

          
            vals.Add("Pk_no_cgc", int.Parse(txt_NoCGCSelect.Text));
            cn.GuardarDatosCGC(table, vals);


            valores.Add("tbl_cgc_Pk_no_cgc", int.Parse(txt_NoCGCSelect.Text));


            cn.GuardarDatos(tabla, valores);

            MessageBox.Show("Datos guardados");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void btn_guardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
            await Task.Delay(1000);
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar el cierre
            DialogResult result = MessageBox.Show("¿Deseas volver?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si elige "No", no cerrar la form
            if (result == DialogResult.Yes)
            {
                // Cerrar la Form2
                this.Close();
            }
        }
    }
}
