// Ejercicio 08 - Salario simple
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio08 : Form
    {
        public FormEjercicio08()
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

            double salario = horastrabajadas * tarifa;
            lblResultado.Text = "El salario del trabajador es: " + salario;
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
