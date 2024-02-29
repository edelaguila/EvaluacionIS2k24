using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_PrototipoMenu
{
    public partial class frmSedes : Form
    {
        public frmSedes()
        {
            InitializeComponent();
            //se a agreaga estas dos lineas para que el navegador que esta en el mantenimiento pueda ser leido 
            //y almacenar los datos en la base de datos
            this.navegador1.config("sedes", this, "");
            // se agrega lo que es la seguridad y se puede implementar de dicha forma.
            this.navegador1._initSeguridad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Ayudas/AyudaP1.chm", "AyudaIS.html");
        }
    }
}
