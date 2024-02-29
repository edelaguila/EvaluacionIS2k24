using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// carlos enrique guzman cabrera
namespace Vista_PrototipoMenu
{
    public partial class frmMantenimientoRenapPersonas : Form
    {
        public frmMantenimientoRenapPersonas()
        {
            InitializeComponent();
            this.navegador1.config("tbl_renap", this, "");
            this.navegador1._initSeguridad();

            cb_genero.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            cb_estado.SelectedIndexChanged += estadoCivil;

            txt_dpi.TextChanged += TextBox1_TextChanged;
            txt_dpi.MaxLength = 13;
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de enviar la opción seleccionada
            txt_genero.Clear();

            // Obtener la opción seleccionada del ComboBox y enviarla al TextBox
            string opcionSeleccionada = cb_genero.SelectedItem.ToString();
            txt_genero.Text = opcionSeleccionada;
        }

        private void estadoCivil(object sender, EventArgs e)
        {
            // Limpiar el TextBox antes de enviar la opción seleccionada
            txt_estadoCivil.Clear();

            // Obtener la opción seleccionada del ComboBox y enviarla al TextBox
            string opcionSeleccionada = cb_estado.SelectedItem.ToString();
            txt_estadoCivil.Text = opcionSeleccionada;
        }

       

        private async void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_dpi.Text.Length == 13)
            {
                Mensaje.Visible = true;
                await Task.Delay(5000);
                Mensaje.Visible = false;
            }
            else
            {
                Mensaje.Visible = false;
            }
        }

    }
}
