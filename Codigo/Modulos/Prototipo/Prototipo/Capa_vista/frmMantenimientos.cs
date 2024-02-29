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
    public partial class frmMantenimientos : Form
    {
        public frmMantenimientos()
        {
            InitializeComponent();
        }

        public void _configForm(string table, string posFix)
        {
            navegador1.config(table, this);
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Tag = c.Tag.ToString() + posFix;
                }
            }
            this.dataGridView1.Tag = table;
            if (posFix.Equals("maestro"))
            {
                txtCarnet.Tag = "codigo_maestro";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtEstado.Text = "1";
            }
            else
            {
                txtEstado.Text = "0";
            }
        }
    }
}
