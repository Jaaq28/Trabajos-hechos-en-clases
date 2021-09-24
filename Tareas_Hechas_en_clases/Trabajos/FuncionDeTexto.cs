using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajos
{
    public partial class FuncionDeTexto : Form
    {
        public FuncionDeTexto()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            //obtener la longitud de la cedena ingresada.
            LongitudTextBox.Text = cadena.Length.ToString();

            //Obtener el Primer elemento o caracter.
            PrimerCaracterTextBox.Text = cadena.Substring(0, 1);
            
            //Obtener el ultimo elemto o caracter.
            UltimoTextBox.Text = cadena.Substring(cadena.Length - 1, 1);
            
            //Rango de x a y de caracter.
            RangoTextBox.Text = cadena.Substring(5, 15);

            //convertir a Mayusculas.
            MayusculasTextBox.Text = cadena.ToUpper();
            
            //convertir a Minusculas.
            MinusculasTextBox.Text = cadena.ToLower();

            //remplazar un caracter por otro.
            remplazarTextBox.Text = cadena.Replace("a", "b");

            //solo la primer letra en mayuscula.
            primeraMayusculaTextBox.Text = cadena.Substring(0, 1).ToUpper() + cadena.Substring(1, cadena.Length - 1).ToLower();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadenaTextBox.Clear();
            LongitudTextBox.Clear();
            PrimerCaracterTextBox.Clear();
            UltimoTextBox.Clear();
            RangoTextBox.Clear();
            MayusculasTextBox.Clear();
            MinusculasTextBox.Clear();
            remplazarTextBox.Clear();
            primeraMayusculaTextBox.Clear();
        }
    }
}
