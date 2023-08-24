using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Generar un vector aleatorio de longitud 5
            Random random = new Random();
            double[] vector = new double[5];
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.NextDouble() * 10; // Números aleatorios entre 0 y 10
            }

            // Convertir el vector a una cadena para mostrarlo en la ListBox
            string vectorString = "[" + string.Join(", ", vector) + "]";

            // Agregar el vector a la ListBox
            lstVectores.Items.Add(vectorString);
        }
    }
}
