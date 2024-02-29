using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;


namespace Reporteador
{
    public partial class Form1 : Form
    {
        
        Controlador cn = new Controlador();
        string app = "tbl_aplicacion";
        
        public Form1()
        {
            
            InitializeComponent();
            actualizardatagriew();
        }
        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTblapl(app);
            dgv_aplicacion.DataSource = dt;

        }
        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            if (dgv_aplicacion.SelectedRows.Count > 0)
            {
                int correlativo = Convert.ToInt32(dgv_aplicacion.SelectedRows[0].Cells["fk_no_reporteAsociado"].Value);

                string rutaInforme = cn.ObtenerRutaInformePorCorrelativo(correlativo);

                if (!string.IsNullOrEmpty(rutaInforme))
                {
                    CapaVista.VistaNav vistaReportesNav = new CapaVista.VistaNav();
                    vistaReportesNav.CargarInforme(rutaInforme);
                    vistaReportesNav.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró la ruta del informe para este correlativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una aplicación en el DataGridView para ver el informe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_categorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
