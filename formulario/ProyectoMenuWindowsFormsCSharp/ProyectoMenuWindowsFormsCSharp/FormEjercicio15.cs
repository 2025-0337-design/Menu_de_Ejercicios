// Ejercicio 15 - Suma y producto de pares del 20 al 30
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio15 : Form
    {
        public FormEjercicio15()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int suma = 0;
            int producto = 1;

            for (int x = 20; x <= 30; x = x + 2)
            {
                suma = suma + x;
                producto = producto * x;
            }

            lstResultados.Items.Clear();
            lstResultados.Items.Add("Rango: numeros pares del 20 al 30");
            lstResultados.Items.Add("La suma es: " + suma);
            lstResultados.Items.Add("El producto es: " + producto);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstResultados.Items.Clear();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
