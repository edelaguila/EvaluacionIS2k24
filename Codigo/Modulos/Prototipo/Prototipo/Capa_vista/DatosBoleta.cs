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
    public partial class DatosBoleta : Form
    {
        Controlador controller = new Controlador();
        public DatosBoleta()
        {
            InitializeComponent();
        }

        private void btnvalidarboleta_Click(object sender, EventArgs e)
        {
            string noboleta = txtnoboleta.Text;
            int bole = int.Parse(noboleta);
            string nocgc = txt_nocorrelativo.Text;
            int cgc = int.Parse(nocgc);

            if (controller.BuscarYMostrarBoleta(bole, cgc))
            {
                frmDatosPersonales datos = new frmDatosPersonales();
                datos.txtboleta.Text = bole.ToString();  
                datos.txtcgc.Text = nocgc.ToString();
                datos.Show();
            }
            else
            {
                MessageBox.Show("Boleta o Correlativo no encontrado");
            }
        }


    }
}
