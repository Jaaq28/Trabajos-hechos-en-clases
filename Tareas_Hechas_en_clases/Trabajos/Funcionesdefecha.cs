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
    public partial class Funcionesdefecha : Form
    {
        public Funcionesdefecha()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fechaIngresada = FechaTimePicker.Value;

            NumerodeDiaTextBox.Text = fechaIngresada.Day.ToString();
            NumerodeMesTextBox.Text = fechaIngresada.Month.ToString();
            AñoTextBox.Text = fechaIngresada.Year.ToString();
            HoraTextBox.Text = fechaIngresada.Hour.ToString();

            MesenLetraTextBox.Text = fechaIngresada.ToString("MMMM");

            int numeroDias = Convert.ToInt32(AgregartextBox.Text);
            int numeroDiasARestar  = Convert.ToInt32(DiasARestarTexbox.Text);

            NuevaFechacondiasTexbox.Text = fechaIngresada.AddDays(numeroDias).ToLongDateString();
            NuevaFechaRestadaTextBox.Text = fechaIngresada.AddDays(-numeroDiasARestar).ToLongDateString();

            EdadTextBox.Text = DevolverEdad(fechaIngresada).ToString();

        }
        //funcion de edad.
        private int DevolverEdad(DateTime fechaNacimeinto) 
        {
            DateTime _fechaNacimiento = fechaNacimeinto;
            DateTime _fechaActual = DateTime.Now;

            int Edad;

            if (_fechaNacimiento.Day >= _fechaActual.Day)
            {
                return 0;
            }
            {
                Edad = _fechaActual.Year - _fechaNacimiento.Year;
                if(_fechaActual.Month > _fechaActual.Month)
                {
                    --Edad;
                }
                return Edad;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HoraLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void Funcionesdefecha_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
