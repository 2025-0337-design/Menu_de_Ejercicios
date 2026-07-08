// Ejercicio 23 - Operaciones hasta ingresar cero
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio23 : Form
    {
        private double c = 0;

        public FormEjercicio23()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtNum1.Text, out double num1))
            {
                MessageBox.Show("Ingresa un numero valido en el primer campo");
                return;
            }

            c = c + 1;

            if (num1 != 0)
            {
                if (!double.TryParse(txtNum2.Text, out double num2))
                {
                    txtNum2.Enabled = true;
                    MessageBox.Show("Ingresa un numero valido en el segundo campo");
                    txtNum2.Focus();
                    return;
                }

                double suma = num1 + num2;
                double resta = num1 - num2;
                double multiplicacion = num1 * num2;
                double division = num2 != 0 ? Math.Round(num1 / num2, 2) : 0;

                lstResultados.Items.Add("-- Proceso N." + c + " --");
                lstResultados.Items.Add("Suma: " + suma);
                lstResultados.Items.Add("Resta: " + resta);
                lstResultados.Items.Add("Multiplicacion: " + multiplicacion);
                lstResultados.Items.Add("Division: " + (num2 != 0 ? division.ToString() : "division por cero"));

                txtNum1.Clear();
                txtNum2.Clear();
                txtNum2.Enabled = false;
                txtNum1.Focus();
            }
            else
            {
                lstResultados.Items.Add("--- Final del proceso ---");
                btnCalcular.Enabled = false;
            }
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out double val) && val != 0)
                txtNum2.Enabled = true;
            else
                txtNum2.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c = 0;
            txtNum1.Clear();
            txtNum2.Clear();
            txtNum2.Enabled = false;
            lstResultados.Items.Clear();
            btnCalcular.Enabled = true;
            txtNum1.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
