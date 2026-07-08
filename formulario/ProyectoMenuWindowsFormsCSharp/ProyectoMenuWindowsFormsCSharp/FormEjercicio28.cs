// Ejercicio 28 - Suma desde el 8 hasta N
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio28 : Form
    {
        public FormEjercicio28()
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

            if (numero < 8)
            {
                lblResultado.Text = "El numero ingresado es menor a 8";
            }
            else
            {
                int suma = 0;
                for (int x = 8; x <= numero; x = x + 1)
                    suma = suma + x;

                lblResultado.Text = "La suma de la serie del 8 hasta " + numero + " es: " + suma;
            }
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
