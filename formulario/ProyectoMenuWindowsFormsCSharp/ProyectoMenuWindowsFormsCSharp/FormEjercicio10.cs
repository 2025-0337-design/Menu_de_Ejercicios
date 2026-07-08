// Ejercicio 10 - Suma de los digitos de un numero
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio10 : Form
    {
        public FormEjercicio10()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumero.Text, out int numero))
            {
                MessageBox.Show("Ingresa un numero entero valido");
                return;
            }

            int suma = 0;
            int n = numero;
            do
            {
                int residuo = n % 10;
                suma = suma + residuo;
                n = (n - (n % 10)) / 10;
            }
            while (n != 0);

            lblResultado.Text = "La suma de los digitos es: " + suma;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            lblResultado.Text = "";
            txtNumero.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
