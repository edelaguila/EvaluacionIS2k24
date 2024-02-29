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
    public partial class frmMantenimientoPrecioB : Form
    {
        public frmMantenimientoPrecioB()
        {
            InitializeComponent();
            this.navegador1.config("tbl_preciopasaporte", this, "");
            this.navegador1._initSeguridad();
        }

        private void frmMantenimientoPrecioB_Load(object sender, EventArgs e)
        {

        }
    }
}
