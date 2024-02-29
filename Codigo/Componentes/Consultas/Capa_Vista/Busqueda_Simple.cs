using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//comentado por javier juarez
namespace Capa_VistaConsultas
{
    // Josue Amaya 0901-19-12421
    // Busqueda Simple Usuario 
    public partial class Busqueda_Simple : Form
    {
        Capa_ControladorConsultas.csControldor csn = new Capa_ControladorConsultas.csControldor();

        public String tableN1 = "";
        String datobuscar = "";
        String buscaren = "";
        String cadenaB = "";
        //Muestra el resultado de la Busqueda
        public Busqueda_Simple()
        {
            InitializeComponent();
            panelResultado.Visible = true;

        }
        //Boton salir
        private void btn_SalirBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Boton para cancelar la busqueda
        private void btn_CancelarBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Metodo para realizar busqueda
        
        //Carga el resultado de la busqueda
        
        //Limpia el panel de busqueda
       
        //Muestra el resultado de la búsqueda en la tabla N1
        private void panelResultado_Paint(object sender, PaintEventArgs e)
        {
            CargarColumnas(cbox_columnas, tableN1);
        }


        //Metodo para buscar dato y cargarlo en la tabla N1
        private void bnt_buscaPor_Click(object sender, EventArgs e)
        {
            datobuscar = txt_BuscaPor.Text;
            buscaren = cbox_columnas.Text;

            BuscaPor(datobuscar, buscaren, tableN1);
            CargarColumnas(cbox_columnas, tableN1);
            cadenaB = "";

        }
        //Metodo para obtener datos que se cargaran a la tabla N1
        public void CargarColumnas(ComboBox cbox_columnas, String tableN)
        {
            int ndgv = dgvDato.Columns.Count;

            for (int i = 0; i < ndgv; i++)
            {
                String nameC;
                nameC = dgvDato.Columns[i].HeaderText;
                int ncbx = cbox_columnas.Items.Count;
                if (ncbx < ndgv)
                {
                    cbox_columnas.Items.Add(nameC);
                }
            }
        }
        //Metodo para buscar un dato por medio de un atributo especifico
        private void BuscaPor(string datobuscar, string buscaren, string tableN)
        {
            DataTable dt = new DataTable();
            csn.BuscarPor(datobuscar, buscaren, tableN, dt, lbl_cadena);

            if (dt.Rows.Count > 0)
            {
                panelResultado.Visible = true;
                dgvDato.DataSource = dt;
                cadenaB = "";
                datobuscar = "";
                buscaren = "";
                txt_BuscaPor.Text = "";
            }
        }

        private void dgvDato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbo_buscaren_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

