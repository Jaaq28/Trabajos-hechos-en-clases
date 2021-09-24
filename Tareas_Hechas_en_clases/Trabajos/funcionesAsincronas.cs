using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajos
{
    public partial class funcionesAsincronas : Form
    {
        public funcionesAsincronas()
        {
            InitializeComponent();
        }

        private void ResultadoLabel_Click(object sender, EventArgs e)
        {

        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            HornearPizzaAsync();
            ResultadoLabel.Text = "Proceso Iniciado";
            ResultadoLabel.Text = "Termino el preceso";
        }

        private void HornearPizza() 
        {
            Thread.Sleep(10000);
        }

        private Task HornearPizzaAsync() 
        {
            return Task.Delay(10000);
        }

        private async void SumarButton_Click(object sender, EventArgs e)
        {
            ResultadoSumaLabel.Text = Convert.ToString(await SumardosValoresAsync(25M, 50M));
        }

        private async Task<decimal> SumardosValoresAsync(Decimal num1, decimal num2) 
        {
              decimal resultado = await Task.Run(()=>
            {
                return num1 + num2;
            });
            return resultado;
        }
        
    }
}
