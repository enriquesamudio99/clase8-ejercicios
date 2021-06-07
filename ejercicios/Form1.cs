using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonVerificarEdad_Click(object sender, EventArgs e)
        {

            string mensaje = "";

            DateTime nacimiento = fechaNacimientoPicker.Value;

            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;

            if (edad >= 18 && edad <= 26)
            {
                mensaje = string.Format("Edad: {0} Años, Puede ingresar al SMO.", edad);
            } else
            {
                mensaje = string.Format("Edad: {0} Años, No puede ingresar al SMO.", edad);
            }

            resultadoVerificacionEdad.Text = mensaje;

        }


        private void buttonPulgadas_Click(object sender, EventArgs e)
        {
            double numeroIngresado = Convert.ToDouble(inputNumero.Text);
            double numeroConvertido = numeroIngresado / 2.54;
            resultadoConversion.Text = string.Format("{0} cm convertido a pulgadas es igual a {1} pulgadas", numeroIngresado, Math.Round(numeroConvertido, 4));
        }

        private void buttonCentimetros_Click(object sender, EventArgs e)
        {
            double numeroIngresado = Convert.ToDouble(inputNumero.Text);
            double numeroConvertido = numeroIngresado * 2.54;
            resultadoConversion.Text = string.Format("{0} pulgadas convertido a centímetros es igual a {1} cm", numeroIngresado, Math.Round(numeroConvertido, 4));
        }

        private void buttonLeerTexto_Click(object sender, EventArgs e)
        {
            string texto = System.IO.File.ReadAllText(@"..\..\texto.txt");

            resultadoTexto.Text = texto;
        }
    }
}
