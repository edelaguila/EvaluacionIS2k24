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


namespace Vista_PrototipoMenu
{
    public partial class frmDatosPersonales : Form
    {
        Controlador controller = new Controlador();
        // int codigo = 7;
        public frmDatosPersonales()
        {
            InitializeComponent();
            controller.CargarOpcionesGenero(cmb_genero);
            controller.CargarOpcionesEstado(cmb_estadocivil);
            controller.CargarOpcionesTez(cmb_tez);
            controller.CargarOpcionesOjos(cmb_ojos);
            controller.CargarOpcionesOcupacion(cmb_ocupacion);

           
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string noboleta = txtboleta.Text;
            int bole = int.Parse(noboleta);
            string nocgc = txtcgc.Text;
            int cgc = int.Parse(nocgc);

            /* ValidacionDeDatos val = new ValidacionDeDatos();
             val.Show();*/
            ValidacionDeDatos myform = new ValidacionDeDatos();
            myform.txtboleta.Text = noboleta.ToString();
            myform.txtcgc.Text = nocgc.ToString();  
            myform.setData(this);
            myform.ShowDialog();
        }

        private void LimpiarCampos()
        {
            //string tabla = "tbl_ordenescompra";
            //string campoid = "ord_id";
            //int ultimoNumeroOrden = controller.ObtenerUltimoNumeroOrden(campoid, tabla);
            //txt_numeroorden.Text = ultimoNumeroOrden.ToString();
            txt_nombres.Clear();
            txt_primera.Clear();
            txt_segundoa.Clear();
            txt_apecasado.Clear();
            dtp_nacimiento.Value = DateTime.Now; // Restablece la fecha actual
            txt_numdoc.Clear();
            txt_nacionalidad.Clear();
            cmb_genero.SelectedIndex = -1;
            cmb_estadocivil.SelectedIndex = -1;
            txt_direccion.Clear();
            txt_celular.Clear();
            txt_telefono.Clear();
            txt_correo.Clear();
            txt_confcorreo.Clear();
            txt_altura.Clear();
            cmb_tez.SelectedIndex = -1;
            cmb_ojos.SelectedIndex = -1;
            cmb_ocupacion.SelectedIndex = -1;
        }

        private void frmDatosPersonales_Load(object sender, EventArgs e)
        {

        }
    }
}
