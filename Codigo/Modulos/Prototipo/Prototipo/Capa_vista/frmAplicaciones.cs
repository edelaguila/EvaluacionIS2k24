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
    public partial class frmAplicaciones : Form
    {
        Seguridad_Controlador.Controlador ctrl;

        Controlador cn = new Controlador();
        public frmAplicaciones()
        {
            this.ctrl = new Seguridad_Controlador.Controlador();
            InitializeComponent();
            this.navegador1.config("alumnos", this, "");
            

        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            
           /* CapaVista.Navegador.I = "1002";  //código aplicación asignado al formulario
            navegador1.actual = this;
            navegador1.tabla = dataGridView1;
            TextBox[] Grupotextbox = { txtId, txtNombre, txtDescripcion, txtEstado };
            TextBox[] Idtextbox = { txtId, txtNombre };
            navegador1.textbox = Grupotextbox;
            navegador1.textboxi = Idtextbox;
            navegador1.cargar(dataGridView1, Grupotextbox, cn.getNombreBd());
            */





        }

        private void navegador1_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
