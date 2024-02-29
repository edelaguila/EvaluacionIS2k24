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
    public partial class frmMantFacultades : Form
    {   //David Carrillo
        //SE REALIZO EL MANTENIMIENTO PARA FACULTADES UTILIZANDO EL NAVEGADOR
        public frmMantFacultades()
        {
            InitializeComponent();
            this.navegador1.config("facultades", this, "");
            this.navegador1._initSeguridad();
        }
    }
}
