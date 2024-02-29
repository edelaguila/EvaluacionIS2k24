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

namespace CapaVista_RegAlum
{
    public partial class Registro_Estudiantes : Form
    {
        public Registro_Estudiantes()
        {
            Seguridad_Controlador.Controlador cont = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            navegador1.config("alumnos", this);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
