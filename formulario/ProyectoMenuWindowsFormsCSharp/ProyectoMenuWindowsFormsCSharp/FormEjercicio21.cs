// Ejercicio 21 - 10 procesos con dos numeros
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio21 : Form
    {
        private double c = 0;

        public FormEjercicio21()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (c >= 10)
            {
                MessageBox.Show("Ya se completaron los 10 procesos");
                return;
            }
            if (!double.TryParse(txtNum1.Text, out double num1))
            {
                MessageBox.Show("Ingresa un numero valido en el primer campo");
                return;
            }
            if (!double.TryParse(txtNum2.Text, out double num2))
            {
                MessageBox.Show("Ingresa un numero valido en el segundo campo");
                return;
            }

            c = c + 1;
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

            if (c >= 10)
            {
                lstResultados.Items.Add("--- Final del proceso ---");
                lblEstado.Text = "Proceso terminado";
                btnCalcular.Enabled = false;
            }
            else
            {
                lblEstado.Text = "Proceso " + (c + 1) + " de 10";
                txtNum1.Focus();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            c = 0;
            txtNum1.Clear();
            txtNum2.Clear();
            lstResultados.Items.Clear();
            lblEstado.Text = "Proceso 1 de 10";
            btnCalcular.Enabled = true;
            txtNum1.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
