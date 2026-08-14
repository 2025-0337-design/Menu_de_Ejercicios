// Ejercicio 02 - Descuento de sueldo
using System;
using System.Windows.Forms;

namespace ProyectoMenuWindowsFormsCSharp
{
    public partial class FormEjercicio02 : Form
    {
        public FormEjercicio02()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSueldo.Text, out double sueldo))
            {
                MessageBox.Show("Ingresa un numero valido en sueldo");
                return;
            }

            double descuento;

            if (sueldo >= 0 && sueldo <= 1000)
                descuento = sueldo * 0.1;
            else if (sueldo <= 2000)
                descuento = (sueldo - 1000) * 0.05 + (1000 * 0.1);
            else if (sueldo > 2000)
                descuento = (sueldo - 2000) * 0.03 + (1000 * 0.05) + (1000 * 0.10);
            else
            {
                lblResultado.Text = "El sueldo no puede ser negativo";
                return;
            }

            descuento = Math.Round(descuento, 2);
            double sueldoneto = Math.Round(sueldo - descuento, 2);

            lblResultado.Text = "Descuento:    " + descuento
                              + "\nSueldo neto: " + sueldoneto;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSueldo.Clear();
            lblResultado.Text = "";
            txtSueldo.Focus();
        }

        private void btnVolver_Click(object sender, EventArgs e) { this.Close(); }
    }
}
