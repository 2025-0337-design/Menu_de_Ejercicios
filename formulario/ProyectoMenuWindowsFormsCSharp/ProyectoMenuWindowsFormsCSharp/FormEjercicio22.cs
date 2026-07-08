// Ejercicio 22 - Cubo y raiz cuadrada
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio22 : Form
    {
        private double c = 0;

        public FormEjercicio22()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNumero.Text, out double numero))
            {
                MessageBox.Show("Ingresa un numero valido");
                return;
            }

            c = c + 1;

            if (numero != 0)
            {
                double cubo = Math.Pow(numero, 3);
                double raizcuadrada = Math.Round(Math.Pow(numero, 0.5), 2);
                lstResultados.Items.Add("Proceso N." + c + " - numero: " + numero);
                lstResultados.Items.Add("  Cubo: " + cubo);
                lstResultados.Items.Add("  Raiz cuadrada: " + raizcuadrada);
                txtNumero.Clear();
                txtNumero.Focus();
            }
            else
            {
                lstResultados.Items.Add("--- Final del proceso ---");
                btnCalcular.Enabled = false;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c = 0;
            txtNumero.Clear();
            lstResultados.Items.Clear();
            btnCalcular.Enabled = true;
            txtNumero.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
