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
    public partial class frmMantMaestros : Form
    {
        //DAVID CARRILLO
        //MANTENIMIENTO DE MAESTROS 
          public frmMantMaestros()
        {
            InitializeComponent();
            this.navegador1.config("maestros", this, "");
            this.navegador1._initSeguridad(); 
        }
    }
}
