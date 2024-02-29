using Controlador_PrototipoMenu;
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

    public partial class ValidacionDeDatos : Form
    {
        Controlador controller = new Controlador();
        public ValidacionDeDatos()
        {
            InitializeComponent();
           
        }

        

        

        public void setData(Form myform)
        {
            foreach (Control c in myform.Controls)
            {
                foreach (Control c2 in this.Controls)
                {
                    if (c.Name == c2.Name)
                    {
                        if (c is TextBox textBoxMyForm && c2 is TextBox textBoxThis)
                        {
                            textBoxThis.Text = textBoxMyForm.Text;
                        }
                        if(c is DateTimePicker myDate && c2 is DateTimePicker date)
                        {
                            date.Value = myDate.Value;
                        }
                        if(c is ComboBox myCmb && c2 is ComboBox cmb)
                        {
                            cmb.Text = myCmb.Text;
                        }
                    }
                }
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

           

        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            string nombre = txt_nombres.Text;
            string Papellido = txt_primera.Text;
            string Sappelido = txt_segundoa.Text;
            string Capellido = txt_apecasado.Text;
            DateTime fechaNacimiento_a = dtp_nacimiento.Value;
            string fechaNacimiento = fechaNacimiento_a.ToString("yyyy-MM-dd");
            string tipodo = txt_tipodoc.Text;
            string numdocs = txt_numdoc.Text;
     
            string nacionalidad = txt_nacionalidad.Text;
            string genero = cmb_genero.Text;
            string estadocivil = cmb_estadocivil.Text;
            string direccion = txt_direccion.Text;
            string celular = txt_celular.Text;
            string telefono = txt_telefono.Text;
            string correo = txt_correo.Text;
            string confcorreo = txt_confcorreo.Text;
            string altura = txt_altura.Text;
            string tez = cmb_tez.Text;
            string ojos = cmb_ojos.Text;
            string ocupacion = cmb_ocupacion.Text;

            string dpis = txt_numdoc.Text;
            long dpi = long.Parse(dpis);


            string noboleta = txtboleta.Text;
            int bole = int.Parse(noboleta);
            string nocgc = txtcgc.Text;
            int cgc = int.Parse(nocgc);

            if (controller.InsertarDocumento(dpi, numdocs, nacionalidad, genero, estadocivil, nombre, Papellido, Sappelido, fechaNacimiento, Capellido))
            {
                MessageBox.Show("Datos personales ingresados correctamente");
                controller.InsertarDatosPersonales(nombre, Papellido, Sappelido, fechaNacimiento, direccion, celular, telefono, correo, confcorreo, altura, tez, ojos, ocupacion, Capellido,dpi);

                Calendario_citas cand = new Calendario_citas();
              

               //cand.txtcitanum.Text = dpis.ToString();
                cand.txtboleta.Text = noboleta.ToString();
                cand.txtcgc.Text = nocgc.ToString();
                cand.txtdpi.Text = dpi.ToString();
                cand.ShowDialog();


            }

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {

        }
    }


}


