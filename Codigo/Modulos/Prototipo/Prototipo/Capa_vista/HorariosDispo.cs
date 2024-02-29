using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_PrototipoMenu;


namespace Vista_PrototipoMenu
{
    public partial class HorariosDispo : Form
    {
        Controlador ctrl = new Controlador();
        public HorariosDispo()
        {
            InitializeComponent();

            radioButton1.CheckedChanged += RadioButton_CheckedChanged;
            radioButton2.CheckedChanged += RadioButton_CheckedChanged;
            radioButton3.CheckedChanged += RadioButton_CheckedChanged;
            radioButton4.CheckedChanged += RadioButton_CheckedChanged;
            radioButton5.CheckedChanged += RadioButton_CheckedChanged;
            radioButton6.CheckedChanged += RadioButton_CheckedChanged;
            radioButton7.CheckedChanged += RadioButton_CheckedChanged;
            radioButton8.CheckedChanged += RadioButton_CheckedChanged;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            if (radioButton != null && radioButton.Checked)
            {
                labelhora.Text = radioButton.Text;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            string cita = lblidcita.Text;

            string dep = labeldep.Text;
            string fecha = labelfecha.Text;
            string muni = labelmuni.Text;
            string pais = labelpais.Text;
            string hora = labelhora.Text;

            string boleta = labelbol.Text;
            int bolet = int.Parse(boleta);
            string cgcc = labelcgc.Text;
            int cgc = int.Parse(cgcc);
            string dpis = labeldpi.Text;
            int dpi = int.Parse(dpis);

            // Variables para agendar cita.
            if (string.IsNullOrEmpty(lblidcita.Text))
            {
                Random random = new Random();
                int numeroAleatorio = random.Next(10000, 999999999);

                lblidcita.Text = numeroAleatorio.ToString();

                ctrl.InsertarCitas(numeroAleatorio, fecha, hora, dep, pais, bolet, dpi, cgc);
                MessageBox.Show("Cita Agendada");
            }
            else
            {
                // Para reagendar
                bool exito = ctrl.ActualizarCitas(int.Parse(cita), fecha, hora, dep, muni);

                if (exito)
                {
                    MessageBox.Show("Cita actualizada correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la cita");
                }
            }
        }
    }
}
