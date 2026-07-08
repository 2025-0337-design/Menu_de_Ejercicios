// Ejercicio 13 - Factorial de un numero
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio13 : Form
    {
        public FormEjercicio13()
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

            int factorial = 1;
            for (int i = 1; i <= numero; i++)
                factorial = factorial * i;

            lblResultado.Text = numero + "! = " + factorial;
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
