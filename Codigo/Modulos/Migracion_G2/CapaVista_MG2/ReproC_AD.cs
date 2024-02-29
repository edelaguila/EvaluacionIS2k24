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

namespace CapaVista_MG2
{
    public partial class ReproC_AD : Form
    {
        Seguridad_Controlador.Controlador ctrl;
        public ReproC_AD()
        {
            this.ctrl = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            navegador1.config("cita", this);
        }
    }
}
