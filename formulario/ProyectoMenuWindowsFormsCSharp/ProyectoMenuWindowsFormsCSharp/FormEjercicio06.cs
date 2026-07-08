// Ejercicio 06 - Suma de los primeros N numeros
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio06 : Form
    {
        public FormEjercicio06()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtN.Text, out int numero))
            {
                MessageBox.Show("Ingresa un numero entero valido");
                return;
            }

            lstNumeros.Items.Clear();
            int suma = 0;

            for (int x = 1; x <= numero; x = x + 1)
            {
                suma = suma + x;
                lstNumeros.Items.Add("n" + x + ": " + x);
            }

            lblResultado.Text = "La suma de la serie es: " + suma;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtN.Clear();
            lstNumeros.Items.Clear();
            lblResultado.Text = "";
            txtN.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
