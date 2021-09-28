using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Usuario
    {
        //propiedades,caracteristicas



        //Atributos
        private string apellido;


        //propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos
        {
            set { apellido = value; }

            get { return apellido; }

        }

        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        public Usuario()
        {
        }

        public Usuario(string codigo, string correo)
        {
            Codigo = codigo;
            Correo = correo;
        }

        public Usuario(string codigo, string nombre, string apellidos, int edad, string correo, string contrasena) : this(codigo, nombre)
        {
            Apellidos = apellidos;
            Edad = edad;
            Correo = correo;
            Contrasena = contrasena;
        }

        //metodos

        public string GetNombreCompleto(string nombres, string apellidos)
        {
            string _NombreCompleto = nombres + "" + apellidos;
            return _NombreCompleto;
        }
    }
}
