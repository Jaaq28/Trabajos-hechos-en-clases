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
    public partial class Funciones : Form
    {
        public Funciones()
        {
            InitializeComponent();
        }
        //ejecutable del procedimiento Limpiar control aqui se coloca para llamarla.
        private void LimpiarButton_Click(object sender, EventArgs e)
        {
            LimpiarControl();
        }
        //procediemiento de limpiar.
        private void LimpiarControl() 
        {
            Numero1TextBox.Clear();
            Numero2TextBox.Clear();
            ResultadoLabel.Text = string.Empty;
        }
        //procedimiento de sumar.
        private int Suma(int valor1,int valor2) 
        {
            return valor1 + valor2;
        }
        //procedimiento de resta.
        private int Resta(int valor1,int valor2) 
        {
            int resta = valor1 - valor2;
            return resta;
        }
        //procedimiento de Multiplicar.
        private int Multiplicar(int valor1, int valor2) 
        {
            return valor1 * valor2;
        }
        //procedimiento de Dividir.
        private int Dividir(int valor1, int valor2) 
        {
            return valor1 / valor2;
        }

        private void SumaButton_Click(object sender, EventArgs e)
        {
           ResultadoLabel.Text = Suma(Convert.ToInt32(Numero1TextBox.Text),Convert.ToInt32( Numero2TextBox.Text)).ToString();
        }

        private void RestaButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Resta(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void MultiplicacionButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Multiplicar(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }

        private void DividirButton_Click(object sender, EventArgs e)
        {
            ResultadoLabel.Text = Dividir(Convert.ToInt32(Numero1TextBox.Text), Convert.ToInt32(Numero2TextBox.Text)).ToString();
        }
    }
}
