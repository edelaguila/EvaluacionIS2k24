using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad_Controlador;

namespace Vista_PrototipoMenu
{
    //Andrea Corado 0901-20-2841 29/02/2024
    public partial class frmAplicaciones : Form
    {
        Controlador cn = new Controlador();
        public frmAplicaciones()
        {
            InitializeComponent();
            //se a agreaga estas dos lineas para que el navegador que esta en el mantenimiento pueda ser leido 
            //y almacenar los datos en la base de datos
            this.navegador1.config("maestros", this,"");
            // se agrega lo que es la seguridad y se puede implementar de dicha forma.
            this.navegador1._initSeguridad();
           
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "Ayuda/AyudaP1.chm", "AyudaIS.html");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/AyudaP1.chm", "AyudaIS.html");
        }
    }
}
