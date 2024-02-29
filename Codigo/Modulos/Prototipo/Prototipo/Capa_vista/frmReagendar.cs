using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_PrototipoMenu;


namespace Vista_PrototipoMenu
{
    public partial class frmReagendar : Form
    {
        //Controlador
        Controlador ctrl = new Controlador();


        public frmReagendar()
        {

            InitializeComponent();



            textBox1.MouseClick += textBox1_MouseClick;
            textBox2.MouseClick += textBox2_MouseClick;

            textBox1.MouseClick += textBox1_MouseClick;
            textBox2.MouseClick += textBox2_MouseClick;
            textBox3.MouseClick += textBox3_MouseClick;

            textBox1.Text = "-----";
            textBox2.Text = "-----";
            textBox3.Text = "-----";
            panel1.Paint += panel1_Paint;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;

     
            Pen borde = new Pen(Color.Black, 2);

            int radio = 10; 
            Rectangle rectangulo = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);

            g.DrawArc(borde, rectangulo.X, rectangulo.Y, radio * 2, radio * 2, 180, 90);
            g.DrawLine(borde, rectangulo.X + radio, rectangulo.Y, rectangulo.X + rectangulo.Width - radio, rectangulo.Y);
            g.DrawArc(borde, rectangulo.X + rectangulo.Width - radio * 2, rectangulo.Y, radio * 2, radio * 2, 270, 90);
            g.DrawLine(borde, rectangulo.X + rectangulo.Width, rectangulo.Y + radio, rectangulo.X + rectangulo.Width, rectangulo.Y + rectangulo.Height - radio);
            g.DrawArc(borde, rectangulo.X + rectangulo.Width - radio * 2, rectangulo.Y + rectangulo.Height - radio * 2, radio * 2, radio * 2, 0, 90);
            g.DrawLine(borde, rectangulo.X + radio, rectangulo.Y + rectangulo.Height, rectangulo.X + rectangulo.Width - radio, rectangulo.Y + rectangulo.Height);
            g.DrawArc(borde, rectangulo.X, rectangulo.Y + rectangulo.Height - radio * 2, radio * 2, radio * 2, 90, 90);
            g.DrawLine(borde, rectangulo.X, rectangulo.Y + radio, rectangulo.X, rectangulo.Y + rectangulo.Height - radio);

            borde.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, EventArgs e)
        {
            if (textBox1.Text == "-----")
            {
                textBox1.Text = string.Empty;
            }


        }

        private void textBox2_MouseClick(object sender, EventArgs e)
        {
            if (textBox2.Text == "-----")
            {
                textBox2.Text = string.Empty;
            }


        }

        private void textBox3_MouseClick(object sender, EventArgs e)
        {
            if (textBox3.Text == "-----")
            {
                textBox3.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int noBoleta = int.Parse(textBox1.Text);
                int noCGC = int.Parse(textBox2.Text);
                int noDocumento = int.Parse(textBox3.Text);

                bool citaEncontrada = ctrl.BuscarCita(noBoleta, noDocumento, noCGC);
                int CitaNum = ctrl.ObtenerCitaNum();

                MessageBox.Show("Cita Encontrada" + CitaNum);
                if (citaEncontrada)
                {
                    MessageBox.Show("Cita Encontrada"+CitaNum);
                    Calendario_citas formAgendarCita = new Calendario_citas();
                    formAgendarCita.txtcitanum.Text = CitaNum.ToString();
                    formAgendarCita.txtboleta.Text = noBoleta.ToString();
                    formAgendarCita.txtcgc.Text = noCGC.ToString();
                    formAgendarCita.txtdpi.Text = noDocumento.ToString();
                    formAgendarCita.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cita no encontrada o datos invalidos");
                    Console.WriteLine(noBoleta);
                    Console.WriteLine(noDocumento);
                    Console.WriteLine(noCGC);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
