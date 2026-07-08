// Ejercicio 01 - Salario con horas extra
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio01 : Form
    {
        public FormEjercicio01()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtHoras.Text, out double horastrabajadas))
            {
                MessageBox.Show("Ingresa un numero valido en horas trabajadas");
                return;
            }
            if (!double.TryParse(txtTarifa.Text, out double tarifa))
            {
                MessageBox.Show("Ingresa un numero valido en tarifa");
                return;
            }

            double salario;

            if (horastrabajadas <= 40 && horastrabajadas >= 0)
            {
                salario = horastrabajadas * tarifa;
                lblResultado.Text = "El salario es: " + salario;
            }
            else if (horastrabajadas > 40)
            {
                double horasextra = horastrabajadas - 40;
                double tarifaextra = tarifa + 0.5 * tarifa;
                salario = horasextra * tarifaextra + 40 * tarifa;
                lblResultado.Text = "El salario es: " + salario;
            }
            else
            {
                lblResultado.Text = "Las horas trabajadas no pueden ser negativas";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtHoras.Clear();
            txtTarifa.Clear();
            lblResultado.Text = "";
            txtHoras.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
