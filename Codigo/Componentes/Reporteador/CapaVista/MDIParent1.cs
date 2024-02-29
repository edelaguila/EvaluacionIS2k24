using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reporteador;

namespace CapaVista
{
    public partial class MdiParent1 : Form
    {
        public MdiParent1()
        {
            InitializeComponent();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void navegadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 nuevo = new Form1();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void reporte1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporte2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes nuevo = new Reportes();
            nuevo.MdiParent = this;
            nuevo.Show();
        }

        private void reporte1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prubacrystal prueba = new prubacrystal();
            prueba.MdiParent = this;
            prueba.Show();

        }

        private void reporte2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prueba2 prueba = new prueba2();
            prueba.MdiParent = this;
            prueba.Show();
        }

        private void reporte3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plantilla3 prueba = new Plantilla3();
            prueba.MdiParent = this;
            prueba.Show();
        }

        private void reporte4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Plantilla4 prueba = new Plantilla4();
            prueba.MdiParent = this;
            prueba.Show();
        }
    }
}
