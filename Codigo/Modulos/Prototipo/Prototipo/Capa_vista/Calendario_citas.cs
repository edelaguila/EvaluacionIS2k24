using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista_PrototipoMenu
{
    public partial class Calendario_citas : Form
    {
        public Calendario_citas()
        {
            InitializeComponent();



            monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;

            
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            DateTime fechaSeleccionada = monthCalendar1.SelectionStart;
            txtfecha.Text=fechaSeleccionada.ToString("yyyy-MM-dd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string idcita = txtcitanum.Text;
            string boleta = txtboleta.Text;
            string cgc = txtcgc.Text;
            string dep = comboDept.Text;
            string dpi = txtdpi.Text;
            string fecha = txtfecha.Text;
            //string hora = txtcitanum.Text;
            string muni = txtmuni.Text;
            string pais = txtpais.Text;
          //  string hora = t.Text;



            HorariosDispo frmhor = new HorariosDispo();
            frmhor.lblidcita.Text = idcita.ToString();
            frmhor.labelbol.Text = boleta.ToString();
            frmhor.labelcgc.Text = cgc.ToString();
            frmhor.labeldep.Text = dep.ToString();
            frmhor.labeldpi.Text = dpi.ToString();
            frmhor.labelfecha.Text = fecha.ToString();
           // frmhor.labelhora.Text = frmhor.ToString();
            frmhor.labelmuni.Text = muni.ToString();
            frmhor.labelpais.Text = pais.ToString();
           // frmhor.labelhora.Text = frmhor.ToString();
            frmhor.ShowDialog();

          /*  HorariosDispo horarios = new HorariosDispo();
            horarios.Show();*/
        }
    }
}
