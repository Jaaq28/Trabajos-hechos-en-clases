using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.Codigo = "NACASCO";
            usuario.Correo = "nacasco@poo.com";
            usuario.Nombre = "NAUM";
            usuario.Apellidos = "CASCO";

            MessageBox.Show(usuario.GetNombreCompleto(usuario.Nombre, usuario.Apellidos));
        }
    }
}
