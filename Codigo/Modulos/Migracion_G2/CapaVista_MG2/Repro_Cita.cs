using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador_MG2;

namespace CapaVista_MG2
{
    public partial class Repro_Cita : Form
    {
        string tabla = "Cita";
        Controlador cn = new Controlador();
        public Repro_Cita()
        {
            InitializeComponent();
            MostrarDatos();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fechaseleccionada = monthCalendar1.SelectionStart;
            fecha_n.Text = fechaseleccionada.ToString("yyyy/MM/dd");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int corr = Convert.ToInt32(txtIDCita.Text);

            this.cn.updateCita(corr, monthCalendar1.SelectionStart);
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            textBoxID_TextChanged(sender, e);
        }

        public void MostrarDatos()
        {
            DataTable dt = cn.llenarTbl(tabla);
            dataGridView1.DataSource = dt;
        }
        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            // Verificar si el TextBox está vacío
            if (string.IsNullOrWhiteSpace(txtIDCita.Text))
            {
                LimpiarLabels(); // Limpiar los Labels si no hay texto en el TextBox
                return;
            }

            int idABuscar;
            // Intentar convertir el texto del TextBox a un entero
            if (!int.TryParse(txtIDCita.Text, out idABuscar))
            {
                // Si el texto no es un número entero, puedes mostrar un mensaje de error, limpiar los Labels, o hacer cualquier otra acción necesaria
                MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIDCita.Text = ""; // Limpiar el TextBox
                LimpiarLabels(); // Limpiar los Labels
                return;
            }

            // Buscar la fila correspondiente al ID ingresado en el DataGridView
            DataGridViewRow fila = dataGridView1.Rows
                                        .Cast<DataGridViewRow>()
                                        .FirstOrDefault(r => r.Cells["Corre_cita"].Value.ToString() == idABuscar.ToString());

            if (fila != null)
            {
                // Mostrar los datos de la fila en los Labels
                lblNombre.Text = fila.Cells["Nombre"].Value.ToString();
                lblDPI.Text = fila.Cells["dpi"].Value.ToString();
                lblFecha.Text = fila.Cells["fecha_i"].Value.ToString();
                // Continuar mostrando los datos de las otras columnas de la misma manera
            }
            else
            {
                MessageBox.Show("ID no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LimpiarLabels(); // Limpiar los Labels si el ID no se encuentra
            }
        }

        // Método para limpiar los Labels
        private void LimpiarLabels()
        {
            lblNombre.Text = "";
            lblDPI.Text = "";
            lblFecha.Text = "";
            // Limpiar los otros Labels de la misma manera
        }


    }
}




