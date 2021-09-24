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
    public partial class Arreglos : Form
    {
        public Arreglos()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //vectores
            int[] arreglo1 = new int[5];

            arreglo1[0] = 40;
            arreglo1[1] = 10;
            arreglo1[2] = 31;
            arreglo1[3] = 56;
            arreglo1[4] = 89;

            int[] arreglo2 = new int[6] { 1, 3, 4, 5, 4, 4 };

            int[] arreglo3 = new int[] { 1, 3, 4, 5, 4, 4 };

            int[] arreglo4 = { 1, 3, 4, 5, 4, 4 };

            string[] arreglo5 = new string[] {"juan","Carlos","Maria","Patricia" };

           // for (int i = 0; i < arreglo5.Length; i++)
            //{
             //   listBox1.Items.Add(arreglo5[i]);
            //}

            foreach(var item in arreglo5) 
            {
                listBox1.Items.Add(item);
            }


        }

        private void OrdenarButton_Click(object sender, EventArgs e)
        {
            int[] Valores = new int[] { 3,6,9,2,1,8,7};

            //ordenar de menor a Mayor
            Array.Sort(Valores);

            //Ordenar de Mayor a Mennor
            Array.Reverse(Valores);

            foreach (var item in Valores)
            {
                listBox2.Items.Add(item);
            }
           
        }
    }
}
