using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_MG2;
using System.Drawing.Printing;


namespace CapaVista_MG2
{
    public partial class RV : Form
    {
        private Controlador controlador;
        private DataTable datosTabla;

        public RV()
        {
            InitializeComponent();
            controlador = new Controlador();
            dgv_datos.Visible = false;
            this.Load += RV_Load;
            btn_buscar.Click += btn_buscar_Click;
        }

        private void RV_Load(object sender, EventArgs e)
        {
            datosTabla = controlador.llenarTbl("alumnos");
            dgv_datos.DataSource = datosTabla;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_correlativo.Text))
            {
                // Buscar la fila correspondiente al correlativo ingresado en el DataTable
                DataRow[] filas = datosTabla.Select($"carnet_alumno = '{txt_correlativo.Text}'");

                if (filas.Length > 0)
                {
                    // Mostrar los datos en los TextBox correspondientes
                    txt_nombre.Text = filas[0]["nombre_alumno"].ToString();
                    txt_dpi.Text = filas[0]["direccion_alumno"].ToString();
                    txt_fechaNac.Text = filas[0]["telefono_alumno"].ToString();
                    txt_lugarNac.Text = filas[0]["email_alumno"].ToString();
                }
                else
                {
                    // Limpiar los TextBox si no se encontraron datos
                    LimpiarTextBox();
                    MessageBox.Show("No se encontraron datos para el correlativo ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Limpiar los TextBox si el correlativo está vacío
                LimpiarTextBox();
                MessageBox.Show("Por favor ingrese un correlativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarTextBox()
        {
            txt_nombre.Text = "";
            txt_dpi.Text = "";
        }

    }
}