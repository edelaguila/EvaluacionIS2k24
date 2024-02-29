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
    public partial class frmMantAlumnos : Form
    {
        public frmMantAlumnos()
        {
            InitializeComponent();
            navegador1.config("alumnos", this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Text = "1";
            }
            else
            {
                textBox3.Text = "0";
            }
        }
    }
}
