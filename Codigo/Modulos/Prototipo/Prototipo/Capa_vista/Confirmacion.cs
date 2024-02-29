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
    public partial class Confirmacion : Form
    {
        public Confirmacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calendario_citas calendario_Citas = new Calendario_citas();
            calendario_Citas.Show();
        }

        private void btn_AgregarBoleta_Click(object sender, EventArgs e)
        {
            DatosBoleta boletadatos = new DatosBoleta();
            boletadatos.Show();
        }
    }
}
